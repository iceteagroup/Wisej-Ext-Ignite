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

using System.Drawing;

namespace Wisej.Web.Ext.Ignite
{
	/// <summary>
	/// A simple color picker control
	/// </summary>
	public class igColorPicker : igBase
	{

		#region Constructors

		/// <summary>
		/// Constructs a new instance of the <see cref="igColorPicker"/> class.
		/// </summary>
		public igColorPicker() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igColorPicker"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igColorPicker(object options) : base("igColorPicker", options)
		{
			this.WiredEvents = new[] {
			"colorSelected",
			};
		}

		#endregion

		#region Widget Functions

		/// <summary>
		/// Selects a color
		/// </summary>
		public void SelectColor(Color color)
		{
			this.Instance.selectColor(ColorTranslator.ToHtml(Color.FromArgb(color.ToArgb())));
		}

		#endregion
	}
}
