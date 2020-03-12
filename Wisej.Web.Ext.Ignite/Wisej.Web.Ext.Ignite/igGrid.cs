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
	/// The igGrid control is a jQuery grid that includes user interaction features like filtering, 
	/// grouping, column hiding and resizing, paging, row and cell selection
	/// </summary>
	public class igGrid : igBase
	{

		#region Constructors

		/// <summary>
		/// Constructs a new instance of the <see cref="igGrid"/> class.
		/// </summary>
		public igGrid() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igGrid"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igGrid(object options) : base("igGrid", options)
		{
			this.WidgetWiredEvents = new[] {
			"cellClick",
			"cellRightClick",
			"columnsCollectionModified",
			"dataBinding",
			"dataBound",
			};
		}

		#endregion

	}
}
