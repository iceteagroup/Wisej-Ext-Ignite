using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igSpreadsheet : TestBase
	{
		public igSpreadsheet()
		{
			InitializeComponent();

			this.igSpreadsheet1.Widget.activeWorksheetChanged += new WidgetEventHandler(igSpreadsheet_WidgetEvent);
		}

		private void igSpreadsheet_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void igSpreadsheet_Load(object sender, EventArgs e)
		{
			this.igSpreadsheet1.Call("loadWorkbookFile", "Data/Spreadsheet/statistic.xlsx");
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
		}
	}
}
