﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igRating : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igRating()
		{
			InitializeComponent();

			this.igRating1.Widget.hoverChange += new WidgetEventHandler(igRating_WidgetEvent);
			this.igRating1.Widget.valueChange += new WidgetEventHandler(igRating_WidgetEvent);
		}

		private void igRating_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igRating1.Widget.value(this.numericUpDown1.Value);

			this.igRating1.Update();
		}
	}
}
