using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igHierarchicalGrid : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igHierarchicalGrid()
		{
			InitializeComponent();

			this.igHierarchicalGrid1.Widget.cellClick += new WidgetEventHandler(igHierarchicalGrid_WidgetEvent); 
			this.igHierarchicalGrid1.Widget.rowCollapsed += new WidgetEventHandler(igHierarchicalGrid_WidgetEvent);
			this.igHierarchicalGrid1.Widget.cellRightClick += new WidgetEventHandler(igHierarchicalGrid_WidgetEvent);
		}

		private void igHierarchicalGrid_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
