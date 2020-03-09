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
	}
}
