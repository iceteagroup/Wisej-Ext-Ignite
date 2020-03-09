﻿using System;
using System.Drawing;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igColorPicker : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igColorPicker()
		{
			InitializeComponent();

			this.igColorPicker1.Widget.colorSelected += new WidgetEventHandler(igColorPicker_WidgetEvent);
		}

		private void igColorPicker_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			this.label4.BackColor = System.Drawing.Color.FromName(e.Data);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igColorPicker1.SelectColor(ColorTranslator.FromHtml(this.textBox1.Text));

			this.igColorPicker1.Update();
		}
	}
}
