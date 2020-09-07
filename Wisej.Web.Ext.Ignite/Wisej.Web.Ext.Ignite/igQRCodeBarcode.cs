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
	/// The igQRBarcode control is a HTML5, canvas-based control. It renders QR (Quick Response) 
	/// Codes representing alphanumeric data such as a URL.
	/// </summary>
	public class igQRCodeBarcode : igBase
	{

		#region Constructors

		/// <summary>
		/// Constructs a new instance of the <see cref="igQRCodeBarcode"/> class.
		/// </summary>
		public igQRCodeBarcode() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igQRCodeBarcode"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igQRCodeBarcode(object options) : base("igQRCodeBarcode", options)
		{
			this.WiredEvents = new[] {
				"dataChanged",
				"errorMessageDisplaying"
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

		/// <summary>
		/// Specifies the data encoded in the Barcode
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public string Data
		{
			get
			{
				return this.Options.data ?? "";
			}
			set
			{
				this.Options.data = value;
			}
		}

		#endregion
	
	}
}
