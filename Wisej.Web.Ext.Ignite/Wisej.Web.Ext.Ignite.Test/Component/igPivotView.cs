using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igPivotView : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igPivotView()
		{
			InitializeComponent();
			this.igPivotView1.Call("loadTheData");
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igPivotView1.Options.pivotGridOptions.allowSorting = this.checkBox2.Checked;
			this.igPivotView1.Options.pivotGridOptions.compactColumnHeaders = this.checkBox3.Checked;
			this.igPivotView1.Options.pivotGridOptions.gridOptions.alternateRowStyles = this.checkBox1.Checked;

			this.igPivotView1.Update();
		}
	}
}
