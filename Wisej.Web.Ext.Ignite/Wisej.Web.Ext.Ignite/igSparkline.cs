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
	/// The igSparkline is a data-intense, design-simple control that allows end users to spot trends, 
	/// variations and patterns in data in a clear and compact representation.
	/// </summary>
	public class igSparkline : igBase
	{

		#region Constructors

		/// <summary>
		/// Constructs a new instance of the <see cref="igSparkline"/> class.
		/// </summary>
		public igSparkline() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igSparkline"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igSparkline(object options) : base("igSparkline", options)
		{
			this.WiredEvents = new[] {
			"dataBinding",
			"dataBound",
			"hideTooltip",
			"updateTooltip"
			};
		}

		#endregion

		#region Widget Functions

		/// <summary>
		/// Inserts a new item to the data source and notifies the chart.
		/// </summary>
		/// <param name="item">The JSON object to insert</param>
		/// <param name="index">The index to insert at</param>
		public void InsertItem(object item, int index)
		{
			this.Instance.insertItem(item, index);
		}

		#endregion

	}
}
