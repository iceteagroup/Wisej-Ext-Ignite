using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igZoombar : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igZoombar()
		{
			InitializeComponent();
		}

		private void igZoombar_Load(object sender, EventArgs e)
		{

		}

		private void igZoombar1_Appear(object sender, EventArgs e)
		{

		}

		private void igDataChart1_Appear(object sender, EventArgs e)
		{
			this.igZoombar1.Options.target = $"#id_{this.igDataChart1.Handle}_container";
		}
	}
}
