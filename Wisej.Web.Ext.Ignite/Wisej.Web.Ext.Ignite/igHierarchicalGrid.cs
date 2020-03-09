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
	/// The igHierarchicalGrid is built on top of the fastest jQuery grid on the market, the igGrid. It adds the capability to display hierarchical data sets.
	/// </summary>
	public class igHierarchicalGrid : igBase
	{
		#region Constructors
		/// <summary>
		/// Constructs a new instance of the <see cref="igHierarchicalGrid"/> class.
		/// </summary>
		public igHierarchicalGrid() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igHierarchicalGrid"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igHierarchicalGrid(object options) : base("igHierarchicalGrid", options)
		{
			this.WidgetWiredEvents = new[] {
				"cellClick",
				"cellRightClick",
				"childGridCreated",
				"childGridCreating",
				"chlidrenPopulated",
				"childrenPopulating",
				"columnsCollecctionModified",
				"created",
				"dataBinding",
				"dataBound",
				"dataRendered",
				"dataRendering",
				"destroyed",
				"requestError",
				"rowCollapsed",
				"rowCollapsing",
				"rowExpanded",
				"rowExpanding",
				"schemaGenerated"
			};
		}

		#endregion

	}
}
