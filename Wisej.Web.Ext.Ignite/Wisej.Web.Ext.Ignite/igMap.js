//# sourceURL=wisej.web.ext.IgniteWidget.igMap.js

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

this.resizeWidget = function () {

	if (this.widget) {
		var bounds = this.getBounds();
		if (bounds) {
			try {
				this.widget.option({
					width: bounds.width - 2,
					height: bounds.height - 2
				});
			} catch (ex) { }

			if (typeof (this.widget.redraw) === "function") {
				this.widget.redraw();
			}
			else if (typeof (this.widget.refresh) === "function") {
				this.widget.refresh();
			}
		}
	}
}

// Returns a data map that can be converted to JSON.
this.filterEventData = function (args) {

    switch (args.type) {
        case "seriesMouseLeftButtonUp":
            return {
                item: args.item,
            };
            break;
    }
};