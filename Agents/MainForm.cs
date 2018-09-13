using System;
using System.Windows.Forms;

namespace Agents
{
    public partial class MainForm : Form
    {
        private Scene scene = new Scene();

        public MainForm()
        {
            InitializeComponent();
        }

        private void BSimulate_Click(object sender, EventArgs e)
        {
            scene.ArrivalMinDur = (int)nudArrivalFrom.Value;
            scene.ArrivalMaxDur = (int)nudArrivalTo.Value;
            scene.ServiceMinDur = (int)nudServiceFrom.Value;
            scene.ServiceMaxDur = (int)nudServiceTo.Value;
            scene.HandlersCount = (int)nudServicers.Value;
            scene.QueueCapacity = (int)nudQueueCapacity.Value;

            var stat = scene.Simulate((int)nudSimulationTime.Value);
            log.Items.Clear();

            foreach (var agent in stat.Agents)
            {
                log.Items.Add(agent.ToString());
            }

            log.Items.Add(string.Format("Processed: {0} / {1} ({2:0.00}%)", stat.Processed, stat.Arrived, stat.Percent));
            log.Items.Add(string.Format("Max length of the queue: {0}", stat.MaxQueueLength));
            log.Items.Add("Handlers:");

            foreach (var handler in stat.Handlers)
            {
                log.Items.Add(handler.ToString());
            }
        }
    }
}
