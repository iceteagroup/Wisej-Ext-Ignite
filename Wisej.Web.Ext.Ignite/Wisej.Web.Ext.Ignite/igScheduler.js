//# sourceURL=wisej.web.ext.IgniteWidget.igScheduler.js

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


// Returns a data map that can be converted to JSON.
this.filterEventData = function (args) {

	switch (args.type) {

		case "appointmentDeleted":
			return args.appointmentId;
			break;

		case "appointmentCreated":
		case "appointmentDeleting":
			return {
				start: args.appointment._af,
				end: args.appointment._ad,
				resourceId: args.appointment._au,
				location: args.appointment._b7,
				appointmentId: args.appointment._ar,
				subject: args.appointment._av,
				recurrence: args.appointment._as,
				description: args.appointment._aq
			};
			break;

		case "appointmentCreating":
			return {
				start: args.appointment.start,
				end: args.appointment.end,
				subject: args.appointment.subject,
				location: args.appointment.location,
				description: args.appointment.description,
				resourceId: args.appointment.resourceID,
				recurrence: args.appointment.recurrence
			};
			break;

		case "agendaRateChanged":
		case "agendaRateChanging":
			return {
				dateRangeInterval: args.dateRangeInterval,
				newAgendaRangeStartDate: args.newAgendaRangeStartDate
			};
			break;

	}
};

/**
 * Returns the appointments that fall in the specified date range
 * @param {any} start the beginning of the date range
 * @param {any} end the end of the date range
 */
this.getAppointmentsInRange = function(start, end) {

	var data = this.widget.getAppointmentsInRange(start, end);

	var formattedResult = [];

	for (var i = 0; i < data.length; i++)
	{
		formattedResult[i] = {
			start: data[i]._af,
			end: data[i]._ad,
			resourceId: data[i]._au,
			location: data[i]._b7,
			appointmentId: data[i]._ar,
			subject: data[i]._av,
			recurrence: data[i]._as,
			description: data[i]._aq
		}
	}

	return formattedResult;
}