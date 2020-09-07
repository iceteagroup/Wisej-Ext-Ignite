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


using System.ComponentModel;

namespace Wisej.Web.Ext.Ignite
{
	/// <summary>
	/// The igTreeGrid control is a jQuery widget that displays data in a tree-like tabular structure.
	/// </summary>
	public class igTreeGrid : igBase
	{

		#region Constructors

		/// <summary>
		/// Constructs a new instance of the <see cref="igTreeGrid"/> class.
		/// </summary>
		public igTreeGrid() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igTreeGrid"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igTreeGrid(object options) : base("igTreeGrid", options)
		{
			this.WiredEvents = new[] {
			"cellClick",
			"cellRightClick",
			"columnsCollectionModified",
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

		#region Widget Properties

		/// <summary>
		/// If no columns collection is defined, and autoGenerateColumns is set to true, 
		/// columns will be inferred from the data source before the dataRendering event is fired.
		/// </summary>
		public bool AutoGenerateColumns
		{
			get 
			{
				return this.Options.autoGenerateColumns ?? true;
			}
			set 
			{
				if (this.Options.autoGenerateColumns != value)
					this.Options.autoGenerateColumns = value;
			}
		}

		/// <summary>
		/// Specifies a remote URL as a data source, from which data will be retrieved
		/// </summary>
		public string DataSourceURL
		{
			get
			{
				return this.Options.dataSourceUrl ?? "";
			}
			set
			{
				if (this.Options.dataSourceUrl != value)
					this.Options.dataSourceUrl = value;
			}
		}

		#endregion

	}
}
