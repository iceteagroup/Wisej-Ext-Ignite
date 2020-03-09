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


using System;
using System.ComponentModel;

namespace Wisej.Web.Ext.Ignite
{
	/// <summary>
	/// The igTimePicker control is an editor with time-only input and a drop-down with listed hours:minutes values.
	/// </summary>
	public class igTimePicker : igBase
	{

		#region Constructors

		/// <summary>
		/// Constructs a new instance of the <see cref="igTimePicker"/> class.
		/// </summary>
		public igTimePicker() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igTimePicker"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igTimePicker(object options) : base("igTimePicker", options)
		{
			this.WidgetWiredEvents = new[] {
			"blur",
			"dropDownItemSelected",
			"dropDownItemSelecting",
			"dropDownListClosed",
			"dropDownListClosing",
			"dropDownListOpened",
			"dropDownListOpening",
			"focus",
			"keydown",
			"keypress",
			"keyup",
			"mousedown",
			"mousemove",
			"mouseout",
			"mouseover",
			"mouseup",
			"textChanged",
			"valueChanged",
			"valueChanging"
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

		/// <summary>
		/// Specifies the time value of the widget
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public string Value
		{
			get
			{
				return this.Options.value ?? new DateTime().ToShortTimeString();
			}
			set
			{
				if (this.Options.value != value)
					this.Options.value = value;
			}
		}

		#endregion
	}
}
