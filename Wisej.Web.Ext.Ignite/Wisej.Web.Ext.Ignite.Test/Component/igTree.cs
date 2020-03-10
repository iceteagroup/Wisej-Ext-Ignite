using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igTree : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igTree()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.igTree1.Widget.addNode(new {
				ID = 4,
				RegionName = this.textBox1.Text,
				Countries = new[] { 
					new { 
						ID = 1,
						CountryName = "United States"
					}, 
					new {
						ID = 2,
						CountryName = "Canada"
					}, new {
						ID = 3,
						CountryName = "Mexico"
					}
				}
			});

			this.igTree1.Update();
		}
	}
}
