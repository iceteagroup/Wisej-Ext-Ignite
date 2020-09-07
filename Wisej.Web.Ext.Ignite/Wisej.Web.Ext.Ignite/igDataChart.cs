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
			this.WiredEvents = new[] {
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

		#region Widget Functions

		#region Widget Functions

		/// <summary>
		/// Inserts a new item at the specified index
		/// </summary>
		/// <param name="item">The item to insert</param>
		/// <param name="dataSourceIndex">The index to insert the item at in the series</param>
		/// <param name="seriesIndex">The series to insert the item into</param>
		public void InsertItem(object item, int dataSourceIndex, int seriesIndex)
		{
			if (dataSourceIndex < 0 || seriesIndex < 0) { return; }

			var dataSourceCount = this.Options.series[seriesIndex].dataSource.Length;

			// Expand the array by one item
			var newDataSource = new object[dataSourceCount + 1];

			// Insert the elements into the new array
			var inserted = 0;
			for (int i = 0; i < dataSourceCount; i++)
			{
				if (dataSourceIndex == i)
				{
					newDataSource[i] = item;
					inserted++;
				}
				newDataSource[i + inserted] = this.Options.series[seriesIndex].dataSource[i];
			}

			// Update the dataSource
			this.Options.series[seriesIndex].dataSource = newDataSource;

			this.Update();
		}

		/// <summary>
		/// Adds a new item to the data source
		/// </summary>
		/// <param name="item">The item to insert</param>
		/// <param name="seriesIndex">The series to insert the item into</param>
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

		#endregion
	}
}
