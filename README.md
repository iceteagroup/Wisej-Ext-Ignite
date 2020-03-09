# <img src="https://wisej.com/wp-content/uploads/2018/09/Wisej-Black.png" height="42" align="top"/> Wisej-Ignite

Ignite UI™ is an advanced HTML5+ toolset that helps you create stunning, modern Web apps. Building on jQuery and jQuery UI, it primarily consists of feature rich, high-performing UI controls/widgets such as all kinds of charts, data visualization maps, (hierarchical, editable) data grids, pivot grids, enhanced editors (combo box, masked editors, HTML editor, date picker, to name a few), flexible data source connectors, and a whole lot more.


## Concept
For the premium Syncfusion, DevExtreme, Ignite UI, and Telerik KendoUI integration packages we have used an approach different from the other integrations we publish on the open Wisej repositories. In this case we wanted to use all the features that are available to javascript, angular, react, blazor developers instead of trying to build a limited .NET object hierarchy.

When you look at the code, you will find a common base class **igBase** for all the widgets classes. Overloaded constructors that indicate which ig1 class to use, and a number of initialization options that may be different for some widgets.

The igBase class uses a custom **wisej.web.ext.Ignite** implementation that takes care of the creation and registration of events, methods, and templates. It also provides some simple methods to override in each derived class.

Each specific class has it's own nested .js file that may add specific functionality to filter event data to make it serializable for the server, make sure the wrapped widget fits the container, and whatever else may be needed to make the integration as smooth as possible.

All the premium extensions are open projects, meaning that we will keep adding, fixing, changing, and expanding them according to the requirements of our Technology Partners and needs we find on our projects using these extensions.

## License
To use this extension you need to acquire at least a **JavaScript Bundle** license from Infragistics: https://www.infragistics.com/products/ignite-ui.

## Demo
Not yet available

## Work in progress
The library and test are in progress - we are adding every available widget to the test app and will keep refining the intergration for the foreseable future.

## How to use
All the integrated widgets have 3 types of members: options, methods, and events. The options (you'll find them under "Configuration" in the API Reference documentation) are represented by a single javascript map. Methods are javascript functions. Events in the Ignite widgets are callback methods defined in the options map.

### Options
When using the ig classes in your .NET Wisej application, you have access to the entire set of options using a single property, Options. It is a dynamic .NET object and you can use it directly or assign it.

When you set the Options using the designer, you can simply copy and paste (and edit) any JSON string.

When you set (or change) the Options by code, you can

- Assign the fields directly using the built-in dynamic objects,
- Assign an object that has the properties you want to use,
- Assign an anonymous class.

Assigning the fields directly will automatically update the widget on the client when the property that changes is on the first level. In case your code changes properties deeper than the first level in the hierarchy, you need to call widget1.Update().

~~~
this.igDataChart1.Options.title = textBox1.Text;

this.igDataChart1.Options.axes[0].name = "xAxis";

this.igDataChart1.Update();
~~~

The function BuildRanges() in the code sample below returns a .NET array of .NET classes with the members that match the fields expected by the igRadialGauge widget.

~~~
this.igRadialGauge1.Options.ranges = buildRanges();
~~~

Anonymous classes (example below) allow for a syntax very similar to javascript. However, once you assign an anonymous class instance, you cannot change the value of it's properties. To change a value you have to reassign the anonymous object.

~~~
this.igRadialGauge1.Options.ranges = new Object[] {
				new { name = "range1", 
					brush = "rgba(154, 189, 41, 1)",
					startValue = 70,
					endValue = 100,
					outerStartExtent = 0.55,
					outerEndExtent = 0.65
				},
				new { name = "range2",
					brush = "rgba(100, 145, 41, 1)",
					startValue = 40,
					endValue = 50,
					outerStartExtent = 0.55,
					outerEndExtent = 0.65
				},
			};
~~~

You will find the complete set of options at the Infragistics docs site linked below. Each ig class in the source code also include a direct link to the docs API and Concept pages.

### Methods
All the methods exposed by the javascript ig1 widget are available to your .NET extension class as C# or VB.NET methods using the *Widget* object. All methods are also available as async methods with the "Async" suffix.

Note: When using VB.NET you need to use *Option Strict Off* to allow the .NET dynamic compiler to handle the calls into the *Widget* object.

~~~
// C#
this.igCombo1.Widget.activeIndex(1);

' VB.NET
Me.IgCombo1.Widget.activeIndex(1)
~~~

However, some methods may return values that are not immediately usable in .NET, or you need to use several methods together in a single javascript function in a way that wouldn't make sense from the server. When you need to add a method to your ig widget instance, or your derived class, use the **WidgetFunctions** property in the designer (can be used at runtime as well) to register a new javascript function.

~~~
this.igScheduler1.WidgetFunctions = new []{

  new WidgetFunction()  {
    Name = "setDayViewSettings",
    Source = @"
      this.widget.dayVewSettings = {
        timeSlotInterval: arguments[0],
        dayViewNumberOfDays: arguments[1],
        workingHoursDisplayMode: arguments[2]
    };
    ";
  }
};

this.igScheduler1.Call("setDayViewSettings", "tenMinutes", "3", "workingHoursOnly");

// In alternative (C#):
this.igScheduler1.Options.dayViewSettings = new {
  timeSlotInterval = "tenMinutes",
  dayViewNumberOfDays = "3",
  workingHoursDisplayMode = "workingHoursOnly"
};

~~~

The code above adds a javascript function "setDayViewSettings" to the Wisej Ignite UI widget and then calls it to set the dayViewSettings of the igScheduler widget.

**Be careful** not to override existing methods. The extension will simply not register your new method and log an error in the JavaScript console.

### Events

The events registered by the ig class (see constructor for each component in the source code) are also available as .NET events exposed by the *Widget* object:

~~~
// C#
this.igRadialGauge1.Widget.valueChanged += new WidgetEventHandler(igRadialGauge1_WidgetEvent);

' VB.NET
Me.IgRadialGauge1.Widget.valueChanged = New WidgetEventHandler(AddressOf Me.IgRadialGauge1_CellClick)
~~~

**Note:** Unfortunately in VB.NET you cannot use *AddHandler* or *Handles* to handle dynamic events. You can attach only a single handle using the syntax above, or attach to the existing *WidgetEvent* event and check the *e.Type* property.

Events fired by the Ignite UI widgets are callbacks, not events. The .NET classes representing each widget already registers a set of events and routes them to the .NET widget's WidgetEvent event. However, if your app needs to handle an event in javascript, you can use the **WidgetEvents** collection to register your event callback.

~~~
this.igRadialGauge1.WidgetEvents = new []{
  new WidgetEvent() {
    Name = "valueChanged",
    Source = @"
      this.makeLowerCase(); // this is not an actual method in the igRadialGauge1 widget.
    "
  }
};
~~~

The event **args** object sent by the widget is available as **e** and the code can refer to the ig widget simply using **this**. Note that in the event code **this** refers to the ig widget, while in function code **this** refers to the Wisej widget and **this.widget** refers to the wrapped ig widget.

## Support

To log issues related to this extension, please use the Issues section of this repository. To log issues related to the usage of this extension in your projects, please use the Issues section in your Technology Partner repository.

You may also fork this project and modify it to fit your needs and if you want to share a change or fix, please create a pull request.

## Documentation

Ignite UI Documentation:

https://www.igniteui.com/help/

Ignite UI API:

https://www.igniteui.com/help/api/2019.2/

Ignite UI Demos:

https://www.igniteui.com/grid/overview


## Redistribution

We have bundled the entire set of JS widgets, themes, and assets in the Wisej.Web.Ext.Ignite assembly as embedded resources. You need to deploy only 1 assembly and your client devices don't need an open internet connection.

## Update

The Ignite UI assets are located in /JavaScript using the same directory structure used in the installation zip you receive from Infragistics when you purchase the license. To update the version of the JS library, simply copy the files over and recompile the project.



---
<img src="http://iceteagroup.com/wp-content/uploads/2017/01/Square-64x64-trasp.png" height="20" align="top"> Copyright (C) ICE TEA GROUP LLC, All rights reserved.
