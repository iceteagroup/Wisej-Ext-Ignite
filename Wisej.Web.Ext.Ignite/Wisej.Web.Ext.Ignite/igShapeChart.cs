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
	///The igShapeChart is an HTML5 control that is a simplified version of the igDataChart.
	/// </summary>
	public class igShapeChart : igBase
	{

		#region Constructors

		/// <summary>
		/// Constructs a new instance of the <see cref="igShapeChart"/> class.
		/// </summary>
		public igShapeChart() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igShapeChart"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igShapeChart(object options) : base("igShapeChart", options)
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
	}
}
