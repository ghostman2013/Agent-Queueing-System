using System;
using System.Collections.Generic;
using System.Linq;

namespace Agents
{
    public class Scene
    {
        public int ArrivalMinDur = 25;
        public int ArrivalMaxDur = 50;
        public int ServiceMinDur = 15;
        public int ServiceMaxDur = 35;
        public int HandlersCount = 2;
        public int QueueCapacity = 7;

        private readonly List<Agent> agents = new List<Agent>();
        private readonly Random random = new GaussianRandom();
        private readonly Queue<Agent> queue = new Queue<Agent>();
        private Handler[] handlers = null;
        private int nextIndex;
        private int arrivalTimer;
        //Statistics
        private int maxQueueLength = 0;

        public void Reset()
        {
            agents.Clear();
            queue.Clear();
            handlers = new Handler[HandlersCount];

            for (int i = 0; i < handlers.Length; ++i)
            {
                handlers[i] = new Handler(i + 1);
            }

            nextIndex = 0;
            arrivalTimer = 0;
            //Statistics
            maxQueueLength = 0;
        }

        private void GenerateAgents(int duration)
        {
            int arrival = random.Next(ArrivalMinDur, ArrivalMaxDur);
            int time = arrival;
            int id = 1;

            while (time < duration)
            {
                int service = random.Next(ServiceMinDur, ServiceMaxDur);
                var agent = new Agent(id++, arrival, service);
                agents.Add(agent);
                arrival = random.Next(ArrivalMinDur, ArrivalMaxDur);
                time += arrival;
            }

            if (agents.Any())
            {
                arrivalTimer = agents.First().Arrival;
            }
        }

        private void UpdateQueue(int dt)
        {
            foreach (var agent in queue)
            {
                agent.QueueTime += dt;
            }

            arrivalTimer -= dt;

            if (arrivalTimer <= 0)
            {
                var agent = agents[nextIndex++];
                arrivalTimer = nextIndex < agents.Count ? agents[nextIndex].Arrival : int.MaxValue;

                if (queue.Count < QueueCapacity)
                {
                    queue.Enqueue(agent);
                    agent.Status = Status.InQueue;
                }
                else
                {
                    agent.Status = Status.Declined;
                }
            }

            if (maxQueueLength < queue.Count)
            {
                maxQueueLength = queue.Count;
            }
        }

        private void UpdateHandlers(int dt)
        {
            foreach (var handler in handlers)
            {
                handler.Process(dt);

                if (handler.Timer == 0)
                {
                    if (queue.Any())
                    {
                        handler.Switch(queue.Dequeue());
                    }
                    else
                    {
                        handler.Clear();
                    }
                }
            }
        }

        private int FindStep(int duration)
        {
            int dt = duration;

            if (!agents.Any())
            {
                return dt;
            }

            if (nextIndex < agents.Count)
            {
                dt = arrivalTimer;
            }

            foreach (var handler in handlers)
            {
                if (handler.IsBusy && dt > handler.Timer)
                {
                    dt = handler.Timer;
                }
            }

            return dt;
        }

        public Statistics Simulate(int duration)
        {
            Reset();
            GenerateAgents(duration);
            int dt = FindStep(duration);
            int time = dt;

            while (time < duration)
            {
                UpdateQueue(dt);
                UpdateHandlers(dt);
                dt = FindStep(duration);
                time += dt;
            }

            return new Statistics(this);
        }

        public class Statistics
        {
            public readonly List<Agent> Agents;
            public readonly int Processed;
            public readonly int Arrived;
            public readonly int MaxQueueLength;
            public readonly HandlerStatistics[] Handlers;
            public double Percent { get => (double)Processed / Arrived * 100.0; }

            public Statistics(Scene scene)
            {
                Agents = scene.agents;
                Processed = GetProcessedCount();
                Arrived = GetArrivedCount();
                MaxQueueLength = scene.maxQueueLength;
                Handlers = GetHandlerStatistics(scene, Processed);
            }

            private int GetProcessedCount() {
                int count = 0;

                foreach (var agent in Agents)
                {
                    if (agent.Status == Status.Free)
                    {
                        ++count;
                    }
                }

                return count;
            }

            private int GetArrivedCount()
            {
                int count = 0;

                foreach (var agent in Agents)
                {
                    if (agent.Status != Status.None)
                    {
                        ++count;
                    }
                }

                return count;
            }

            private HandlerStatistics[] GetHandlerStatistics(Scene scene, int processed)
            {
                var handlers = new HandlerStatistics[scene.handlers.Length];
                var hits = new Dictionary<int, int>();

                foreach (var agent in scene.agents)
                {
                    if (agent.Status == Status.Free)
                    {
                        if (hits.ContainsKey(agent.HandlerId))
                        {
                            ++hits[agent.HandlerId];
                        }
                        else
                        {
                            hits[agent.HandlerId] = 1;
                        }
                    }
                }

                for (int i = 0; i < handlers.Length; ++i)
                {
                    var handler = scene.handlers[i];
                    int agentsCount = hits.ContainsKey(handler.Id) ? hits[handler.Id] : 0;
                    var statistics = new HandlerStatistics(handler.Id, agentsCount, (double)agentsCount / processed * 100.0);
                    handlers[i] = statistics;
                }

                return handlers;
            }
        }

        public class HandlerStatistics
        {
            public readonly int Id;
            public readonly int Processed;
            public readonly double ProcessedPercent;

            public HandlerStatistics(int id, int processed, double processedPercent)
            {
                Id = id;
                Processed = processed;
                ProcessedPercent = processedPercent;
            }

            public override string ToString()
            {
                return string.Format("Handler #{0}:\n\tProcessed {1} agents ({2:0.00}%).\n", Id, Processed, ProcessedPercent);
            }
        }

        public class Handler
        {
            public readonly int Id;

            public Agent Agent;
            public int Timer;

            public Handler(int id)
            {
                Id = id;
            }

            public bool IsBusy { get => Agent != null; }

            public Agent Switch(Agent newAgent)
            {
                if (Agent != null)
                {
                    Agent.Status = Status.Free;
                }

                var oldAgent = Agent;
                Timer = newAgent.Service;
                Agent = newAgent;
                Agent.Status = Status.OnService;
                Agent.HandlerId = Id;
                return oldAgent;
            }

            public int Process(int duration)
            {
                Timer = Math.Max(Timer - duration, 0);
                return Timer;
            }

            public void Clear()
            {
                if (Agent != null)
                {
                    Agent.Status = Status.Free;
                }

                Timer = 0;
                Agent = null;
            }
        }
    }
}
