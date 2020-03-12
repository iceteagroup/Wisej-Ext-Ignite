using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igPieChart : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igPieChart()
		{
			InitializeComponent();

			this.igPieChart1.Widget.sliceClick += new WidgetEventHandler(igPieChart_WidgetEvent);
			this.igPieChart1.Widget.labelClick += new WidgetEventHandler(igPieChart_WidgetEvent);
		}

		private void igPieChart_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void button1_Click(object sender, EventArgs e)
		{

			// Doesn't work because Names are in quotes
			this.igPieChart1.Widget.addItem(new {
				Label = this.textBox1.Text,
				Budget = this.numericUpDown1.Value
			});


			this.igPieChart1.Update();

			// Works
			//this.igPieChart1.Call("AddItem");
	}
	}
}
