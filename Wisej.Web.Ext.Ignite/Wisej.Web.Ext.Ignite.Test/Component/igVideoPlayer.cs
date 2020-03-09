﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igVideoPlayer : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igVideoPlayer()
		{
			InitializeComponent();

			this.igVideoPlayer1.Widget.paused += new WidgetEventHandler(igVideoPlayer_WidgetEvent);
			this.igVideoPlayer1.Widget.playing += new WidgetEventHandler(igVideoPlayer_WidgetEvent);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.igVideoPlayer1.Play();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.igVideoPlayer1.Pause();
		}

		private void igVideoPlayer_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
