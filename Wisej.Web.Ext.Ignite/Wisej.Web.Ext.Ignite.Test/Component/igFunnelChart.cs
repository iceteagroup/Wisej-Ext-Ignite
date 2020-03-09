﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igFunnelChart : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igFunnelChart()
		{
			InitializeComponent();

			this.igFunnelChart1.Widget.sliceClicked += new WidgetEventHandler(igFunnelChart1_WidgetEvent);
		}

		private void igFunnelChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
