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
	/// The igBulletGraph is an HTML5, canvas-based bullet graph control. 
	/// It displays a single primary measure and compares to one or more other measures to create a concise data visualization.
	/// </summary>
	public class igBulletGraph : igBase
	{
		#region Constructors
		/// <summary>
		/// Constructs a new instance of the <see cref="igBulletGraph"/> class.
		/// </summary>
		public igBulletGraph() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igBulletGraph"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igBulletGraph(object options) : base("igBulletGraph", options)
		{
			this.WidgetWiredEvents = new[] {
			"alignLabel",
			"formatLabel"
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
		/// Gets or sets the value at which the bar ends.
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
		/// Gets or sets the minimum value of the scale.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public double MinimumValue
		{
			get
			{
				return this.Options.minimumValue ?? 0;
			}
			set
			{
				this.Options.minimumValue = value;
			}
		}

		/// <summary>
		/// Gets or sets the maximum value of the scale.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public double MaximumValue
		{
			get
			{
				return this.Options.maximumValue ?? 0;
			}
			set
			{
				this.Options.maximumValue = value;
			}
		}

		/// <summary>
		/// Specifies the interval value of the widget
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public double Interval
		{
			get
			{
				return this.Options.interval ?? 0.0;
			}
			set
			{
				this.Options.interval = value;
			}
		}

		/// <summary>
		/// Gets or sets the position at which to start rendering the actual value geometries, measured from the front/bottom of the bullet graph as a value from 0 to 1.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public double ValueInnerExtent
		{
			get
			{
				return this.Options.valueInnerExtent ?? 0;
			}
			set
			{
				this.Options.valueInnerExtent = value;
			}
		}

		/// <summary>
		/// Gets or sets the position at which to stop rendering the actual value geometries as a value from 0 to 1 measured from the front/bottom of the bullet graph.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public double ValueOuterExtent
		{
			get
			{
				return this.Options.valueOuterExtent ?? 0;
			}
			set
			{
				this.Options.valueOuterExtent = value;
			}
		}

		#endregion
	}
}
