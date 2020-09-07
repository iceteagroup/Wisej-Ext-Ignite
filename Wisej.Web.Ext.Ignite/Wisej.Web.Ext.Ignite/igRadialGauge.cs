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
	/// The igRadialGauge control can display a gauge with visual elements including a scale with tick marks and labels, a needle, and a number of ranges.
	/// </summary>
	public class igRadialGauge: igBase
	{

		#region Constructors

		/// <summary>
		/// Constructs a new instance of the <see cref="igRadialGauge"/> class.
		/// </summary>
		public igRadialGauge() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igRadialGauge"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igRadialGauge(object options) : base("igRadialGauge", options)
		{
			this.WiredEvents = new[] {
				"alignLabel",
				"formatLabel",
				"valueChanged",
			};
		}

		#endregion
	}
}