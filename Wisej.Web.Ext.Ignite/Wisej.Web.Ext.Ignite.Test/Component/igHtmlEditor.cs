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
	}
}
