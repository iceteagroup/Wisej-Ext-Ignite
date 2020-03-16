using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igTimePicker : TestBase
	{
		public igTimePicker()
		{
			InitializeComponent();

			this.igTimePicker1.Widget.valueChanged += new WidgetEventHandler(igTimePicker_WidgetEvent);
		}

		private void igTimePicker_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
