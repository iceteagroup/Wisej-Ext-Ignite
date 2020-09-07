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
using Wisej.Base;

namespace Wisej.Web.Ext.Ignite
{
	/// <summary>
	/// The igCategoryChart is an HTML5 control that is a simplified version of the igDataChart.
	/// </summary>
	public class igCategoryChart : igBase
	{

		#region Constructors

		/// <summary>
		/// Constructs a new instance of the <see cref="igCategoryChart"/> class.
		/// </summary>
		public igCategoryChart() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igCategoryChart"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igCategoryChart(object options) : base("igCategoryChart", options)
		{
			this.WiredEvents = new[] {
			"calloutStyleUpdating",
			"dataBinding",
			"dataBound",
			"hideTooltip",
			"propertyChanged",
			"seriesAdded",
			"seriesPointerDown",
			"seriesPointerEnter",
			"seriesPointerLeave",
			"seriesPointerMove",
			"seriesPointerUp",
			"seriesRemoved",
			"updateTooltip"
			};
		}

		#endregion

		#region Widget Properties

		/// <summary>
		/// Gets or sets the type of chart series to generate from the data.
		/// </summary>
		[DefaultValue(ChartTypes.auto)]
		[SRCategory("CatBehavior")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public ChartTypes ChartType
		{
			get
			{
				return this._chartType;
			}
			set
			{
				if (this._chartType != value)
				{
					this.Options.chartType = Enum.GetName(typeof(ChartTypes), value);
					this._chartType = value;
				}
			}
		}
		private ChartTypes _chartType = ChartTypes.auto;

		#endregion

		#region Widget Functions

		public void ExportImage()
		{
			this.Call("exportImage");
		}

		#endregion

		#region ChartTypes
		public enum ChartTypes
		{
			/// <summary>
			/// Specifies category line series with markers at each data point.
			/// </summary>
			line,

			/// <summary>
			/// Specifies category area series.
			/// </summary>
			area,

			/// <summary>
			/// Specifies category column chart with vertical rectangles at each data point.
			/// </summary>
			column,

			/// <summary>
			/// Specifies category point chart with markers at each data point.
			/// </summary>
			point,

			/// <summary>
			/// Specifies category step line chart.
			/// </summary>
			stepLine,

			/// <summary>
			/// Specifies category step area chart.
			/// </summary>
			stepArea,

			/// <summary>
			/// Specifies category spline line series with markers at each data point.
			/// </summary>
			spline,

			/// <summary>
			/// Specifies category spline area series.
			/// </summary>
			splineArea,

			/// <summary>
			/// Specifies category waterfall chart.
			/// </summary>
			waterfall,

			/// <summary>
			/// Specifies automatic selection of chart type based on suggestions from Data Adapter.
			/// </summary>
			auto
		}
		#endregion
	}
}
