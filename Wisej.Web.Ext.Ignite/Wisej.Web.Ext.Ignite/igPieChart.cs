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
	/// The igPieChart is a charting control for rendering pie charts in HTML5 Web applications and sites.
	/// </summary>
	public class igPieChart : igBase
	{

		#region Constructors

		/// <summary>
		/// Constructs a new instance of the <see cref="igPieChart"/> class.
		/// </summary>
		public igPieChart() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igPieChart"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igPieChart(object options) : base("igPieChart", options)
		{
			this.WidgetWiredEvents = new[] {
			"browserNotSupported",
			"labelClick",
			"selectedItemChanged",
			"selectedItemChanging",
			"selectedItemsChanged",
			"selectedItemsChanging",
			"sliceClick",
			"tooltipHidden",
			"tooltipHiding",
			"tooltipShowing",
			"tooltipShown"
			};
		}

		#endregion
	}
}
