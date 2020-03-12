//# sourceURL=wisej.web.ext.IgniteWidget.igSpreadsheet.js

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


/**
 * Process the options map before it is used to
 * create or update the widget.
 */
this.filterOptions = function (options) {

    if (options.activeWorksheetChanged)
		options.activeWorksheetChanged = this.initFunction(options.activeWorksheetChanged);
};

this.resizeWidget = function () {

	if (this.widget) {
		var bounds = this.getBounds();
		this.widget.option("width", bounds.width);
		this.widget.option("height", bounds.height);
	}
}

// Returns a data map that can be converted to JSON.
this.filterEventData = function (args) {

	switch (args.type) {

		case "activeWorksheetChanged":
			return {
				oldActiveWorksheetName: args.oldActiveWorksheetName,
				newActiveWorksheetName: args.newActiveWorksheetName
			}
            break;

		default:
			return {};
			break;

	}
}

/**
 * Loads an excel file at the given url
 * @param {any} url The url of the excel file to load
 */
this.loadWorkbook = function (url) {

    if (!this.widget) {
        this.addListenerOnce("initialized", function () {
            this.loadWorkbook(url);
        });
        return;
    }

    this.widget.workbook = null;
    var xhr = new XMLHttpRequest();
    xhr.open('GET', url, true);
    xhr.responseType = "arraybuffer";

    var me = this;
    xhr.onload = function (e) {
        // response is unsigned 8 bit integer
        var responseArray = new Uint8Array(this.response);
        $.ig.excel.Workbook.load(responseArray, function () {
            workbook = arguments[0];
            me.widget.option("workbook", workbook);
            me.widget.workbook = workbook;
        }, function () {
            console.log("Failed to load the requested excel workbook");
        })
    };
    xhr.send()
}


this.exportWorkbook = function () {

    if (!this.widget.workbook) {
        console.log("Workbook doesn't exist");
        return;
    }

    var workbook = this.widget.workbook;

    var me = this;
    workbook.save(function (args) {
        me.fireWidgetEvent("export", args);
    }, function (error) {
        console.log("Error saving the workbook");
    });
}

