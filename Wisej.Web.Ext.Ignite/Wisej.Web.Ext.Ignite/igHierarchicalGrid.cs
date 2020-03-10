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

		#region Widget Functions

		/// <summary>
		/// Inserts a new item at the specified index
		/// </summary>
		/// <param name="item">The item to insert</param>
		/// <param name="index">The index to insert the item at in the series</param>
		public void InsertItem(object item, int index)
		{
			var dataSourceCount = this.Options.dataSource.Length;

			// Expand the array by one item
			var newDataSource = new object[dataSourceCount + 1];

			// Insert the elements into the new array
			var inserted = 0;
			for (int i = 0; i < dataSourceCount; i++)
			{
				if (index == i)
				{
					newDataSource[i] = item;
					inserted++;
				}
				newDataSource[i + inserted] = this.Options.dataSource[i];
			}

			// Update the dataSource
			this.Options.dataSource = newDataSource;

			this.Update();
		}

		/// <summary>
		/// Adds a new item to the end of data source
		/// </summary>
		/// <param name="item">The item to insert</param>
		public void AddItem(object item)
		{
			var dataSourceCount = this.Options.dataSource.Length;

			var newDataSource = new object[dataSourceCount + 1];

			// Creates a new array with the old array
			this.Options.dataSource.CopyTo(newDataSource, 0);
			// Appends the new element
			newDataSource[dataSourceCount] = item;

			this.Options.dataSource = newDataSource;

			this.Update();
		}

		#endregion

	}
}
