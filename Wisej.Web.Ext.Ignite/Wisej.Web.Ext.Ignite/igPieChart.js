﻿//# sourceURL=wisej.web.ext.IgniteWidget.igPieChart.js

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

        case "sliceClick":
            if (args.slice.item.__inner)
                return args.slice.item.__inner;
            else
                return args.slice.item;
            break;

        case "selectedItemChanged":
        case "selectedItemChanging":
            return {
                oldItem: args.oldItem,
                newItem: args.newItem
            };
            break;

        case "selectedItemsChanged":
        case "selectedItemsChanging":
            return {
                oldItems: args.oldItems,
                newItems: args.newItems
            };
            break;

        case "labelClick":
            return args.item;
            break;

        default:
            return args;
            break;

    }
};
