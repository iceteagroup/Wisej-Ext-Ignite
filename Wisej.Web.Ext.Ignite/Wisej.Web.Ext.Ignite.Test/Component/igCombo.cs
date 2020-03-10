using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igCombo : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igCombo()
		{
			InitializeComponent();

			this.igCombo1.Widget.dropDownOpened += new WidgetEventHandler(igCombo_WidgetEvent);
			this.igCombo1.Widget.selectionChanged += new WidgetEventHandler(igCombo_WidgetEvent);
		}

		private void igCombo_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igCombo1.Options.mode = this.comboBox1.SelectedItem;
			this.igCombo1.SetActiveIndex((int)this.numericUpDown1.Value);

			this.igCombo1.Update();
		}
	}
}
