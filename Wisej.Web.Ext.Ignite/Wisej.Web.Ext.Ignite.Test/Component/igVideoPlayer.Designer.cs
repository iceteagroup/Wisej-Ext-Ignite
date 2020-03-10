namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igVideoPlayer
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Wisej Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igVideoPlayer));
			this.igVideoPlayer1 = new Wisej.Web.Ext.Ignite.igVideoPlayer();
			this.button1 = new Wisej.Web.Button();
			this.button2 = new Wisej.Web.Button();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.button1, 0);
			this.groupBox1.Controls.SetChildIndex(this.button2, 0);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igVideoPlayer1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://www.igniteui.com/video-player/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igvideoplayer";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "http://www.igniteui.com/help/igvideoplayer-overview";
			// 
			// igVideoPlayer1
			// 
			this.igVideoPlayer1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igVideoPlayer1.Location = new System.Drawing.Point(27, 26);
			this.igVideoPlayer1.Name = "igVideoPlayer1";
			this.igVideoPlayer1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igVideoPlayer1.Options"))));
			this.igVideoPlayer1.Size = new System.Drawing.Size(399, 260);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(28, 44);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(195, 27);
			this.button1.TabIndex = 1;
			this.button1.Text = "Play";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(28, 144);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(195, 27);
			this.button2.TabIndex = 2;
			this.button2.Text = "Pause";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// igVideoPlayer
			// 
			this.Name = "igVideoPlayer";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igVideoPlayer igVideoPlayer1;
		private Button button2;
		private Button button1;
	}
}
