using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igTreeGrid : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igTreeGrid()
		{
			InitializeComponent();

			this.igTreeGrid1.Widget.cellClick += new WidgetEventHandler(igTree_WidgetEvent);
			this.igTreeGrid1.Widget.cellRightClick += new WidgetEventHandler(igTree_WidgetEvent);
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			var data = JSON.Parse(e.Files[0].InputStream);

			this.igTreeGrid1.Widget.dataSourceObject(data);
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			// Need to add more packages for this
			this.igTreeGrid1.Eval("$.ig.GridExcelExporter.exportGrid(this.widget, { fileName: 'treegrid1' });");
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
