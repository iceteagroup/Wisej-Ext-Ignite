using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igRating : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igRating()
		{
			InitializeComponent();

			this.igRating1.Widget.hoverChange += new WidgetEventHandler(igDataChart_WidgetEvent);
			this.igRating1.Widget.valueChange += new WidgetEventHandler(igDataChart_WidgetEvent);
		}

		private void igDataChart_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
