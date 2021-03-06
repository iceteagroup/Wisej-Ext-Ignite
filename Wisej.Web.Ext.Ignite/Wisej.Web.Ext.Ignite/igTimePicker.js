﻿//# sourceURL=wisej.web.ext.IgniteWidget.igTimePicker.js

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

    this.getContentElement().setStyle("overflow", "visible");
}

// Returns a data map that can be converted to JSON.
this.filterEventData = function (args) {

    switch (args.type) {

        case "dropDownItemSelected":
        case "dropDownItemSelecting":
            return {
                item: args.item
            };
            break;

        case "valueChanged":
        case "valueChanging":
            return {
                newValue: args.newValue,
                originalValue: args.originalValue
            };
            break;

        case "textChanged":
            return {
                text: args.text,
                oldText: args.oldText,
            };
            break;

    }
};