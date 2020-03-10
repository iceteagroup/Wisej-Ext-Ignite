using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igScheduler : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igScheduler()
		{
			InitializeComponent();

			this.igScheduler1.Widget.appointmentCreated += new WidgetEventHandler(igScheduler_WidgetEvent);
			this.igScheduler1.Widget.appointmentDeleted += new WidgetEventHandler(igScheduler_WidgetEvent);
			this.igScheduler1.Widget.appointmentCreating += new WidgetEventHandler(igScheduler_WidgetEvent);
			this.igScheduler1.Widget.appointmentDeleting += new WidgetEventHandler(igScheduler_WidgetEvent);
		}

		private void igScheduler1_Appear(object sender, EventArgs e)
		{
			this.igScheduler1.Call("loadData");
			this.igScheduler1.Update();
		}

		private void igScheduler_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			var data = await this.igScheduler1.CallAsync("getAppointmentsInRange", this.dateTimePicker1.Value, this.dateTimePicker2.Value);

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
	}
}
