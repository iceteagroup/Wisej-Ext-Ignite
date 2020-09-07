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
	/// The igDateEditor control includes a host of configuration options to help you format 
	/// and constrain the date data coming from input forms
	/// </summary>
	public class igDateEditor : igBase
	{
		#region Constructors
		/// <summary>
		/// Constructs a new instance of the <see cref="igDateEditor"/> class.
		/// </summary>
		public igDateEditor() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igDateEditor"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igDateEditor(object options) : base("igDateEditor", options)
		{
			this.WiredEvents = new[] {
			"keydown",
			"keypress",
			"keyup",
			"mousedown",
			"textChanged",
			"valueChanged",
			"valueChanging"
			};
		}

		#endregion
	}
}
