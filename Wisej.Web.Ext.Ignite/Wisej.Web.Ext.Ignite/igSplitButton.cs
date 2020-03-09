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
	/// Split buttons, also known as split drop down buttons, are useful when you want 
	/// to provide a default action/command for a button but also need to supply other, secondary options.
	/// </summary>
	public class igSplitButton : igBase
	{

		#region Constructors

		/// <summary>
		/// Constructs a new instance of the <see cref="igSplitButton"/> class.
		/// </summary>
		public igSplitButton() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igSplitButton"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igSplitButton(object options) : base("igSplitButton", options)
		{
			this.WidgetWiredEvents = new[] {
				"click",
				"collapsed",
				"collapsing",
				"expanded",
				"expanding"
			};
		}

		#endregion
	}
}