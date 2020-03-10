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
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			var data = JSON.Parse(e.Files[0].InputStream);

			this.igTreeGrid1.Widget.dataSourceObject(data);
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			// Need to add more packages for this
			// this.igTreeGrid1.Eval("$.ig.GridExcelExporter.exportGrid(this.widget, { fileName: 'treegrid1' });");
		}
	}
}
