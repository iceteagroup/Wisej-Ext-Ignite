using System;
using System.Threading;
using Wisej.Web.Ext.Ignite.Test.Popups;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igRadialGauge : TestBase
	{
		public GaugeRange newRange = new GaugeRange();

		public igRadialGauge()
		{
			InitializeComponent();

			this.igRadialGauge1.Widget.valueChanged += new WidgetEventHandler(igRadialGauge_WidgetEvent);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igRadialGauge1.Options.value = (int)this.numericUpDown1.Value;

			this.igRadialGauge1.Update();
		}

		private void button2_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show("Start a new task?", icon: MessageBoxIcon.Question, buttons: MessageBoxButtons.YesNo) == DialogResult.No)
			{
				return;
			}

			taskCount++;
			this.button2.Text = $"Start Task ({taskCount})";

			Application.StartTask(() => {

				var rand = new Random();

				for (var i = 0; i < 10; i++)
				{
					this.igRadialGauge1.Options.value = rand.Next(0, 100);
					Application.Update(this);
					Thread.Sleep(1000);
				}

				taskCount--;
				this.button2.Text = $"Start Task ({taskCount})";
				Application.Update(this);
			});
		}

		private int taskCount;

		private async void button1_Click(object sender, EventArgs e)
		{
			var res = await this.igRadialGauge1.Widget.getRangeNamesAsync();

			AlertBox.Show(res);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.igRadialGauge1.Widget.addRange(new
			{
				name = "MyRange",
				brush = "green",
				startValue = 5,
				endValue = 15,
				outerStartExtent = 0.55,
				outerEndExtent = 0.65
			});
		}

		private void igRadialGauge_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
