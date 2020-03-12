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
	/// The igMap is a HTML5 jQuery map control that can render data sets consisting of large number 
	/// of geographic locations in shapes of markers, lines, polygons, and even as interactive bitmaps.
	/// </summary>
	public class igMap : igBase
	{

		#region Constructors

		/// <summary>
		/// Constructs a new instance of the <see cref="igMap"/> class.
		/// </summary>
		public igMap() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igMap"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igMap(object options) : base("igMap", options)
		{
			this.WidgetWiredEvents = new[] {
				"browserNotSupported",
				"gridAreaRectChanged",
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
				"triangulationStatusChanged",
				"windowRectChanged"
			};
		}

		#endregion

	}
}