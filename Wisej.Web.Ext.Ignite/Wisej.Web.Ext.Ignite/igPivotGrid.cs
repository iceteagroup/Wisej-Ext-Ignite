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
	public class igPivotGrid : igBase
	{

		#region Constructors

		/// <summary>
		/// Constructs a new instance of the <see cref="igPivotGrid"/> class.
		/// </summary>
		public igPivotGrid() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igPivotGrid"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igPivotGrid(object options) : base("igPivotGrid", options)
		{
			this.WiredEvents = new[] {
			"dataSourceInitialized",
			"dataSourceUpdated",
			"drag",
			"dragStart",
			"dragStop",
			"filterDropDownClosed",
			"filterDropDownClosing",
			"filterDropDownOk",
			"filterDropDownOpened",
			"filterDropDownOpening",
			"filterMembersLoaded",
			"headersSorted",
			"headersSorting",
			"metadataDropped",
			"metadataDropping",
			"metadataRemoved",
			"metadataRemoving",
			"sorted",
			"sorting",
			"tupleMemberCollapsed",
			"tupleMemberCollapsing",
			"tupleMemberExpanded",
			"tupleMemberExpanding",
			};
		}

		#endregion
	}
}
