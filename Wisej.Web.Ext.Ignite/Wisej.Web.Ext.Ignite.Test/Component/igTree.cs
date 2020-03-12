using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igTree : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igTree()
		{
			InitializeComponent();

			this.igTree1.Widget.nodeClick += new WidgetEventHandler(igTree_WidgetEvent);
			this.igTree1.Widget.nodeExpanded += new WidgetEventHandler(igTree_WidgetEvent);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.igTree1.Widget.addNode(new {
				ID = 4,
				RegionName = this.textBox1.Text,
			});

			this.igTree1.Update();
		}

		private void igTree_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
