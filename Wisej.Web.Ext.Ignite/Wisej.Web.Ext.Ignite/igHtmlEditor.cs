///////////////////////////////////////////////////////////////////////////////
//
// (C) 2020 ICE TEA GROUP LLC - ALL RIGHTS RESERVED
//
// 
//
// ALL INFORMATION CONTAINED HEREIN IS, AND REMAINS
// THE PROPERTY OF ICE TEA GROUP LLC AND ITS SUPPLIERS, IF ANY.
// THE INTELLECTUAL PROPERTY AND TECHNICAL CONCEPTS CONTAINED
// HEREIN ARE PROPRIETARY TO ICE TEA GROUP LLC AND ITS SUPPLIERS
// AND MAY BE COVERED BY U.S. AND FOREIGN PATENTS, PATENT IN PROCESS, AND
// ARE PROTECTED BY TRADE SECRET OR COPYRIGHT LAW.
//
// DISSEMINATION OF THIS INFORMATION OR REPRODUCTION OF THIS MATERIAL
// IS STRICTLY FORBIDDEN UNLESS PRIOR WRITTEN PERMISSION IS OBTAINED
// FROM ICE TEA GROUP LLC.
//
///////////////////////////////////////////////////////////////////////////////


using System.ComponentModel;

namespace Wisej.Web.Ext.Ignite
{
	/// <summary>
	/// The igHtmlEditor control is a jQuery HTML editor control that features standard HTML editing capabilities.
	/// </summary>
	public class igHtmlEditor : igBase
	{

		#region Constructors

		/// <summary>
		/// Constructs a new instance of the <see cref="igHtmlEditor"/> class.
		/// </summary>
		public igHtmlEditor() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igHtmlEditor"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igHtmlEditor(object options) : base("igHtmlEditor", options)
		{
			this.WidgetWiredEvents = new[] {
				"actionExecuted",
				"actionExecuting",
				"copy",
				"cut",
				"paste",
				"redo",
				"toolbarCollapsed",
				"toolbarCollapsing",
				"toolbarExpanded",
				"toolbarExpanding",
				"undo",
				"workspaceResized"
			};
		}

		#endregion

		#region Widget Properties

		/// <summary>
		/// Not applicable for this control
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override string Text { get => base.Text; set => base.Text = value; }

		#endregion

		#region Widget Functions

		public void SetContent(string value, bool isHtml) 
		{
			if (isHtml)
				this.Widget.setContent(value, "html");
			else
				this.Widget.setContent(value, "text");

		}

		#endregion
	}
}