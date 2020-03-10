using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igHtmlEditor : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igHtmlEditor()
		{
			InitializeComponent();

			this.igHtmlEditor1.Widget.copy += new WidgetEventHandler(igHtmlEditor_WidgetEvent);
			this.igHtmlEditor1.Widget.actionExecuted += new WidgetEventHandler(igHtmlEditor_WidgetEvent);
		}

		private void igHtmlEditor_Load(object sender, EventArgs e)
		{
			this.igHtmlEditor1.Options.value = File.ReadAllText(Application.MapPath("Data/HtmlEditor/data.html"));
		}

		private void igHtmlEditor_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			using (StreamReader streamReader = new StreamReader(e.Files[0].InputStream))
			{
				var text = streamReader.ReadToEnd();

				this.igHtmlEditor1.Widget.setContent(text, "html");
			}
		}

		private async void buttonExportData_Click(object sender, EventArgs e)
		{
			var html = await this.igHtmlEditor1.Widget.getContentAsync("html");

			using (MemoryStream ms = new MemoryStream())
			{
				var sw = new StreamWriter(ms);
				try
				{
					sw.Write(html);
					sw.Flush();
					ms.Seek(0, SeekOrigin.Begin);

					Application.Download(ms, "myData.html");
				}
				finally
				{
					sw.Dispose();
				}
			}
		}
	}
}
