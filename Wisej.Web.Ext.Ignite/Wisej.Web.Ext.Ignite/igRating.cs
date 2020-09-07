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
	/// The igRating control is an HTML 5 capable jQuery widget.
	/// </summary>
	public class igRating : igBase
	{

		#region Constructors

		/// <summary>
		/// Constructs a new instance of the <see cref="igRating"/> class.
		/// </summary>
		public igRating() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igRating"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igRating(object options) : base("igRating", options)
		{
			this.WiredEvents = new[] {
				"hoverChange",
				"valueChange"
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
		/// Specifies the value of the widget
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public int Value
		{
			get
			{
				return this.Options.value ?? 0;
			}
			set
			{
				this.Options.value = value;
			}
		}

		/// <summary>
		/// Specifies whether the widget should be shown vertically
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public bool Vertical
		{
			get
			{
				return this.Options.vertical ?? false;
			}
			set
			{
				this.Options.vertical = value;
			}
		}

		#endregion

	}
}