//# sourceURL=wisej.web.ext.IgniteWidget.igDataChart.js

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

		case "axisRangeChanged":
			return {
				axis: args.axis,
				newMaximumValue: args.newMaximumValue,
				newMinimumValue: args.newMinimumValue,
				oldMaximumValue: args.oldMaximumValue,
				oldMinimumValue: args.oldMinimumValue
			};
			break;

		case "seriesMouseMove":
		case "seriesMouseLeave":
		case "seriesMouseLeftButtonUp":
		case "seriesMouseLeftButtonDown":
			return {
				item: args.item,
				series: args.series,
			};
			break;

		case "gridAreaRectChanged":
			return {
				newHeight: args.newHeight,
				newLeft: args.newLeft,
				newTop: args.newTop,
				newWidth: args.newWidth,
				oldHeight: args.oldHeight,
				oldTop: args.oldTop,
				oldWidth: args.oldWidth
			};
			break;

		default:
			return args;
			break;

	}
}

// Exports an image to the user's computer
this.exportImageData = function () {

	var pngData = this.widget.exportImage();
	var a = document.createElement("a"); //Create <a>
	a.href = pngData.src; //Image Base64 Goes here
	a.download = "myChart.png"; //File name Here
	a.click(); //Downloaded file
}