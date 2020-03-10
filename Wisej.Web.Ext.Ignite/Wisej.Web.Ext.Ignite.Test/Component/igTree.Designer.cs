namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igTree
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igTree));
			this.igTree1 = new Wisej.Web.Ext.Ignite.igTree();
			this.groupBox2 = new Wisej.Web.GroupBox();
			this.button1 = new Wisej.Web.Button();
			this.textBox1 = new Wisej.Web.TextBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.groupBox2, 0);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igTree1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://www.igniteui.com/tree/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igtree";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "http://www.igniteui.com/help/igtree-igtree";
			// 
			// igTree1
			// 
			this.igTree1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)));
			this.igTree1.Location = new System.Drawing.Point(135, 18);
			this.igTree1.Name = "igTree1";
			this.igTree1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igTree1.Options"))));
			this.igTree1.Size = new System.Drawing.Size(182, 276);
			this.igTree1.Text = "igTree1";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Location = new System.Drawing.Point(28, 33);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(195, 126);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.Text = "Add Node";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 92);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(183, 27);
			this.button1.TabIndex = 1;
			this.button1.Text = "Add";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Label.Text = "Continent";
			this.textBox1.Location = new System.Drawing.Point(6, 35);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(183, 42);
			this.textBox1.TabIndex = 0;
			// 
			// igTree
			// 
			this.Name = "igTree";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igTree igTree1;
		private GroupBox groupBox2;
		private Button button1;
		private TextBox textBox1;
	}
}
