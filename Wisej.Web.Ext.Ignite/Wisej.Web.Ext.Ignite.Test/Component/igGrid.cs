﻿using System;
using System.IO;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igGrid : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igGrid()
		{
			InitializeComponent();

			this.igGrid1.Widget.cellClick += new WidgetEventHandler(igGrid_WidgetEvent);
			this.igGrid1.Widget.cellRightClick += new WidgetEventHandler(igGrid_WidgetEvent);
		}

		private void igGrid_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			var data = JSON.Parse(e.Files[0].InputStream);

			this.igGrid1.Widget.dataSourceObject(data);
		}

		private async void buttonExport_Click(object sender, EventArgs e)
		{
			var data = await this.igGrid1.Widget.getUnboundValuesAsync();

			using (MemoryStream ms = new MemoryStream())
			{
				var sw = new StreamWriter(ms);
				try
				{
					sw.Write(JSON.Stringify(data));
					sw.Flush();
					ms.Seek(0, SeekOrigin.Begin);

					Application.Download(ms, "myAppointments.json");
				}
				finally
				{
					sw.Dispose();
				}
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igGrid1.Options.enableHoverStyles = this.checkBox1.Checked;
			this.igGrid1.Options.alternateRowStyles = this.checkBox2.Checked;

			this.igGrid1.Update();
		}
	}
}
