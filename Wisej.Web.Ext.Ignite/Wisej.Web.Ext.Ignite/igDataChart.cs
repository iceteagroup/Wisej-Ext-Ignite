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


namespace Wisej.Web.Ext.Ignite
{
	/// <summary>
	/// The igDataChart is a charting control for rendering various kinds of charts into HTML5 Web 
	/// applications and sites. It uses the new Canvas tag in HTML5 to plot data series on web pages.
	/// </summary>
	public class igDataChart : igBase
	{

		#region Constructors

		/// <summary>
		/// Constructs a new instance of the <see cref="igDataChart"/> class.
		/// </summary>
		public igDataChart() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igDataChart"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igDataChart(object options) : base("igDataChart", options)
		{
			this.WidgetWiredEvents = new[] {
				"assigningCategoryMarkerStyle",
				"assigningCategoryStyle",
				"axisRangeChanged",
				"browserNotSupported",
				"gridAreaRectChanged",
				"progressLoadStatusChanged",
				"refreshCompleted",
				"seriesCursorMouseMove",
				"seriesMouseEnter",
				"seriesMouseLeave",
				"seriesMouseLeftButtonDown",
				"seriesMouseLeftButtonUp",
				"seriesMouseMove",
				"tooltipHidden",
				"tooltipHiding",
				"tooltipShowing",
				"tooltipShown",
				"typicalBasedOn",
				"windowRectChanged"
			};
		}

		#endregion
	}
}
