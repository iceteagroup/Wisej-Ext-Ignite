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
	/// The igLinearGauge is useful for showing a single measure on a linear range.
	/// </summary>
	public class igLinearGauge : igBase
	{

		#region Constructors

		/// <summary>
		/// Constructs a new instance of the <see cref="igLinearGauge"/> class.
		/// </summary>
		public igLinearGauge() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igLinearGauge"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igLinearGauge(object options) : base("igLinearGauge", options)
		{
			this.WidgetWiredEvents = new[] {
				"alignLabel",
				"formatLabel",
				"valueChanged",
			};
		}

		#endregion

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
		public double Value
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
		/// Specifies the value of the widget
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public bool IsNeedleDraggingEnabled
		{
			get
			{
				return this.Options.isNeedleDraggingEnabled ?? false;
			}
			set
			{
				this.Options.isNeedleDraggingEnabled = value;
			}
		}
	}
}