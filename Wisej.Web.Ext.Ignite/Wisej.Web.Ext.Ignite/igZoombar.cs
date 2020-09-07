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
	/// The igZoombar is a jQuery UI zooming slider control.
	/// </summary>
	public class igZoombar : igBase
	{

		#region Constructors

		/// <summary>
		/// Constructs a new instance of the <see cref="igZoombar"/> class.
		/// </summary>
		public igZoombar() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igZoombar"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igZoombar(object options) : base("igZoombar", options)
		{
			this.WiredEvents = new[] {
				"providerCreated",
				"windowDragEnded",
				"windowDragEnding",
				"windowDragging",
				"windowDragStarted",
				"windowDragStarting",
				"windowResized",
				"windowResizing",
				"zoomChanged",
				"zoomChanging"
			};
		}

		#endregion

		#region Widget Properties

		/// <summary>
		/// Not applicable for this control
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override string Text { get => base.Text; set => base.Text = value; }

		#endregion
	}
}