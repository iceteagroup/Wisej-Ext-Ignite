using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igFinancialChart : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igFinancialChart()
		{
			InitializeComponent();

			this.igFinancialChart1.Widget.seriesPointerUp += new WidgetEventHandler(igFinancialChart_WidgetEvent);
		}

		private void igFinancialChart_Load(object sender, EventArgs e)
		{
			this.igFinancialChart1.Options.dataSource = JSON.Parse(File.ReadAllText(Application.MapPath("Data/FinancialChart/data.json")));
		}

		private void igFinancialChart_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
