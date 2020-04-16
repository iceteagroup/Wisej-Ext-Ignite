//# sourceURL=wisej.web.ext.IgniteWidget.igVideoPlayer.js

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

this.initWidget = function () {

	this.container.style.overflow = "visible";
};

/**
 * Resizes the hosted widget to always fit our container.
 */
this.resizeWidget = function () {

	if (this.widget) {
		var bounds = this.getBounds();
		if (bounds) {
			try {
				this.widget.option({
					width: bounds.width,
					height: bounds.height - 4
				});
			} catch (ex) { }
		}
	}
}

// Returns a data map that can be converted to JSON.
this.filterEventData = function (args) {

	switch (args.type) {
		case "playing":
		case "paused":
			return {
				currentTime: args.currentTime,
				duration: args.duration,
				source: args.source
			};
			break;
	}
};