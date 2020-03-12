﻿///////////////////////////////////////////////////////////////////////////////
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


namespace Wisej.Web.Ext.Ignite
{
	/// <summary>
	/// The igDoughnutChart displays data similar to a pie chart and can display multiple sets of data around a common center.
	/// </summary>
	public class igDoughnutChart : igBase
	{

		#region Constructors

		/// <summary>
		/// Constructs a new instance of the <see cref="igDoughnutChart"/> class.
		/// </summary>
		public igDoughnutChart() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igDoughnutChart"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igDoughnutChart(object options) : base("igDoughnutChart", options)
		{
			this.WidgetWiredEvents = new[] {
			"browserNotSupported",
			"dataBinding",
			"dataBound",
			"hideTooltip",
			"holeDimensionsChanged",
			"sliceClick",
			"tooltipHidden",
			"tooltipHiding",
			"tooltipShowing",
			"tooltipShown",
			"updateTooltip"
			};
		}

		#endregion
	
	}
}
