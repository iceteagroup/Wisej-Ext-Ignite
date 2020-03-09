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
	/// The igScheduler control provides a common scheduling solution for presenting and managing time periods and the associated activities.
	/// </summary>
	public class igScheduler : igBase
	{

		#region Constructors

		/// <summary>
		/// Constructs a new instance of the <see cref="igScheduler"/> class.
		/// </summary>
		public igScheduler() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igScheduler"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igScheduler(object options) : base("igScheduler", options)
		{
			this.WidgetWiredEvents = new[] {
			"agendaRangeChanged",
			"agendaRangeChanging",
			"appointmentCreated",
			"appointmentCreating",
			"appointmentDeleted",
			"appointmentDeleting",
			"appointmentDialogClosed",
			"appointmentDialogClosing",
			"appointmentDialogOpened",
			"appointmentDialogOpening",
			"appointmentEdited",
			"appointtmentEditing",
			"dayChanged",
			"dayChanging",
			"daySelected",
			"monthChanged",
			"monthChanging",
			"viewChanged",
			"viewChanging",
			"weekChanged",
			"weekChanging"
			};
		}

		#endregion
	}
}
