//# sourceURL=wisej.web.ext.IgniteWidget.igTree.js

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

    if (wisej.web.DesignMode)
        options.animationDuration = 0;

    if (options.dragAndDropSettings)
        if (options.dragAndDropSettings.customDropValidation)
            options.dragAndDropSettings.customDropValidation = this.initFunction(options.dragAndDropSettings.customDropValidation);

};

// Returns a data map that can be converted to JSON.
this.filterEventData = function (args) {

    switch (args.type) {

        case "nodeClick":
            return args.node.data;
            break;

        case "nodeDoubleClick":
            return {
                path: args.path,
                data: args.data
            };
            break;

    }
};

this.update = function (options, old) {

    switch (true) {

        // Some properties require the widget to be recreated
        case (old.initialExpandDepth !== options.initialExpandDepth):
            this.recreateWidget(options);
            break;
        default:
            // Otherwise perform the normal update
            if (this.filterOptions)
                this.filterOptions(options, old);

            this.widget.option(options);
            break;

    }
};