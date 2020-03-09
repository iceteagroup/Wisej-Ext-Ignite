using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igSparkline : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igSparkline()
		{
			InitializeComponent();
		}

		private void igSparkline_Load(object sender, EventArgs e)
		{
			this.igSparkline1.Options.dataSource = JSON.Parse(File.ReadAllText(Application.MapPath("Data/Sparkline/data.json")));
		}
	}
}
