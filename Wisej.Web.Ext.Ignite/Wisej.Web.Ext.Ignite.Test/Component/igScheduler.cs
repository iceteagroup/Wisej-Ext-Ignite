using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igScheduler : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igScheduler()
		{
			InitializeComponent();
		}

		private void igScheduler1_Appear(object sender, EventArgs e)
		{
			this.igScheduler1.Call("loadData");
			this.igScheduler1.Update();
		}
	}
}
