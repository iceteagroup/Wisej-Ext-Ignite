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
	/// The igPivotDataSelector is a jQuery UI widget that enables users to select data slices, typically, when data is being visualized in an igPivotGrid.
	/// </summary>
	public class igPivotDataSelector : igBase
	{

		#region Constructors

		/// <summary>
		/// Constructs a new instance of the <see cref="igPivotDataSelector"/> class.
		/// </summary>
		public igPivotDataSelector() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igPivotDataSelector"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igPivotDataSelector(object options) : base("igPivotDataSelector", options)
		{
			this.WidgetWiredEvents = new[] {
			"dataSourceInitialized",
			"dataSourceUpdated",
			"deferUpdateChanged",
			"drag",
			"dragStart",
			"dragStop",
			"filterDropDownClosed",
			"filterDropDownClosing",
			"filterDropDownOk",
			"filterDropDownOpened",
			"filterDropDownOpening",
			"metadataDropped",
			"metadataDropping",
			"metadataRemoved",
			"metadataRemoving"
			};
		}

		#endregion
	}
}
