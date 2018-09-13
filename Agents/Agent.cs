using System.Text;

namespace Agents
{
    public class Agent
    {
        public const int InvalidServiceId = -1;

        public readonly int Id;
        public readonly int Arrival;
        public readonly int Service;

        public int QueueTime = 0;
        public int HandlerId = InvalidServiceId;
        public Status Status = Status.None;

        public Agent(int id, int arrival, int service)
        {
            Id = id;
            Arrival = arrival;
            Service = service;
        }

        public override string ToString()
        {
            var sb = new StringBuilder().AppendFormat("Agent #{0}: \n", Id).AppendFormat("\tStatus {0}.\n", Status); ;

            if (Status == Status.None)
            {
                return sb.ToString();
            }

            sb.AppendFormat("\tArrived after {0},\n", Arrival);

            if (Status == Status.Declined)
            {
                return sb.ToString();
            }

            sb.AppendFormat("\tWaited for {0},\n", QueueTime);

            if (Status == Status.InQueue)
            {
                return sb.ToString();
            }
            
            return sb.AppendFormat("\tWas processed for {0} by the handler #{1},\n", Service, HandlerId)
                .ToString();
        }
    }

    public enum Status
    {
        None,
        Declined,
        InQueue,
        OnService,
        Free
    }
}
