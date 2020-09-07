﻿///////////////////////////////////////////////////////////////////////////////
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


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Runtime.CompilerServices;
using Wisej.Base;
using Wisej.Core;
using Wisej.Design;

namespace Wisej.Web.Ext.Ignite
{
	/// <summary>
	/// The <see cref="igBase"/> class is the foundation of all Ignite UI visual controls.
	/// </summary>
	[ToolboxBitmap(typeof(igBase), "igIgnite.bmp")]
	public abstract class igBase : Widget, IWisejControl
	{
		internal const string DEFAULT_THEME = "infragistics";
		internal const string NAMESPACE = "Wisej.Web.Ext.Ignite";
		internal const string RESOURCES_ROOT = "Wisej.Web.Ext.Ignite.IgniteUI";
		internal const string THEMENAME_KEY = "Wisej.Web.Ext.Ignite.ThemeName";

		#region Constructors

		/// <summary>
		/// Constructs a new instance of the <see cref="igBase"/> class.
		/// </summary>
		/// <remarks>
		/// See demo at: <see href="https://www.igniteui.com/grid/overview"/>
		/// </remarks>
		/// <param name="className"></param>
		/// <param name="options"></param>
		public igBase(string className, object options)
		{
			if (String.IsNullOrEmpty(className))
				throw new ArgumentNullException(nameof(className));

			this.Options = options;
			this.WidgetClass = className;
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igBase"/> class.
		/// </summary>
		/// <param name="className"></param>
		/// <param name="html"></param>
		/// <param name="options"></param>
		public igBase(string className, string html, object options)
		{
			if (String.IsNullOrEmpty(className))
				throw new ArgumentNullException(nameof(className));

			this.Options = options;
			this.WidgetHtml = html;
			this.WidgetClass = className;
		}

		#endregion

		#region Events

		/// <summary>
		/// Fired when the Ignite widget is created and it available to receive calls.
		/// </summary>
		public event EventHandler Initialized
		{
			add { AddHandler(nameof(Initialized), value); }
			remove { RemoveHandler(nameof(Initialized), value); }
		}

		#endregion

		#region Properties

		/// <summary>
		/// Returns or sets the theme for all the Ignite widgets in the application.
		/// </summary>
		public static string Theme
		{
			get { return Application.Session[THEMENAME_KEY] ?? DEFAULT_THEME; }
			set
			{
				if (String.IsNullOrEmpty(value))
					value = DEFAULT_THEME;

				if (Theme != value)
				{
					Application.Session[THEMENAME_KEY] = value;

					foreach (igBase widget in Application.FindComponents(c => c is igBase))
					{
						widget.Packages.Clear();
						widget.Update();
					}
				}
			}
		}

		/// <summary>
		/// Returns or sets the configuration options;
		/// </summary>
		[DesignerActionList]
		[MergableProperty(false)]
		[SRCategory("CatBehavior")]
		[SRDescription("WidgetOptionsDescr")]
		[WisejSerializerOptions(WisejSerializerOptions.None)]
		public override dynamic Options
		{
			get { return base.Options; }
			set
			{
				if (value != null)
				{
					if (value is string)
					{
						value = WisejSerializer.Parse((string)value);
					}
					else if (!(value is Wisej.Core.DynamicObject))
					{
						// make sure to convert non-writable anonymous classes to
						// our DynamicObject instance.
						value = WisejSerializer.Parse(WisejSerializer.Serialize((object)value));
					}
				}

				base.Options = value;
			}
		}

		/// <summary>
		/// Property for additional Ignite packages
		/// </summary>
		[DefaultValue(null)]
		public Package[] Includes
		{
			get { return this._includes; }
			set
			{
				if (this._includes != value)
				{
					this._includes = value;
					this.Packages.Clear();
				}
			}
		}
		private Package[] _includes;

		/// <summary>
		/// Property for Ignite localization packages
		/// </summary>
		[DefaultValue(null)]
		public Package[] Locales
		{
			get { return this._locales; }
			set
			{
				if (this._locales != value)
				{
					this._locales = value;
					this.Packages.Clear();
				}
			}
		}
		private Package[] _locales;

		/// <summary>
		/// Returns or sets the list of events that are fired by the widget wrapper.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override string[] WiredEvents
		{
			get { return base.WiredEvents; }
			set { base.WiredEvents = value; }
		}

		/// <summary>
		/// Property for required Ignite packages
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override List<Package> Packages
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				var packages = base.Packages;
				if (packages.Count == 0)
				{
					// Ignite UI Required Combined CSS Files
					var themeUrl = igBase.Theme;

					packages.Add(new Package()
					{
						Name = themeUrl,
						Source = this.GetResourceURL($"{RESOURCES_ROOT}/css/themes/{themeUrl}/infragistics.theme.css")
					});
					packages.Add(new Package()
					{
						Name = themeUrl,
						Source = this.GetResourceURL($"{RESOURCES_ROOT}/css/themes/{themeUrl}/icons-styles.css")
					});
					packages.Add(new Package()
					{
						Name = "infragistics.css",
						Source = this.GetResourceURL($"{RESOURCES_ROOT}/css/structure/infragistics.css")
					});

					//packages.Add(new Package()
					//{
					//	Name = "modernizr",
					//	Source = "http://ajax.aspnetcdn.com/ajax/modernizr/modernizr-2.8.3.js"
					//});

					 // Ignite UI Required JS Files
					 packages.Add(new Package()
					{
						Name = "jquery.js",
						Source = this.GetResourceURL($"{RESOURCES_ROOT}/js/jquery.min.js")
					});
					packages.Add(new Package()
					{
						Name = "jquery-ui.js",
						Source = this.GetResourceURL($"{RESOURCES_ROOT}/js/jquery-ui.min.js")
					});
					packages.Add(new Package()
					{
						Name = "modernizr.js",
						Source = this.GetResourceURL($"{RESOURCES_ROOT}/js/modernizr.min.js")
					});
					packages.Add(new Package()
					{
						Name = "infragistics.core.js",
						Source = this.GetResourceURL($"{RESOURCES_ROOT}/js/infragistics.core.js")
					});
					packages.Add(new Package()
					{
						Name = "infragistics.lob.js",
						Source = this.GetResourceURL($"{RESOURCES_ROOT}/js/infragistics.lob.js")
					});
					packages.Add(new Package()
					{
						Name = "infragistics.dv.js",
						Source = this.GetResourceURL($"{RESOURCES_ROOT}/js/infragistics-dv.js")
					});
					packages.Add(new Package()
					{
						Name = "infragistics.excel-bundled.js",
						Source = this.GetResourceURL($"{RESOURCES_ROOT}/js/infragistics.excel-bundled.js")
					});
					packages.Add(new Package()
					{
						Name = "infragistics.spreadsheet-bundled.js",
						Source = this.GetResourceURL($"{RESOURCES_ROOT}/js/infragistics.spreadsheet-bundled.js")
					});
					packages.Add(new Package()
					{
						Name = "infragistics.scheduler-bundled.js",
						Source = this.GetResourceURL($"{RESOURCES_ROOT}/js/infragistics.scheduler-bundled.js")
					});

					// add locales.
					if (this.Locales != null)
					{
						foreach (var l in this.Locales)
						{
							if (l.Source != null)
							{
								if (l.Source.StartsWith("i18n/", StringComparison.InvariantCultureIgnoreCase)
									|| l.Source.StartsWith("i10/", StringComparison.InvariantCultureIgnoreCase))
								{
									this.Packages.Add(new Package
									{
										Name = l.Name,
										Source = $"{RESOURCES_ROOT}/assets/scripts/{l.Source}"
									});
								}
								else
								{
									this.Packages.Add(l);
								}
							}
						}
					}

					// add custom packages.
					if (this.Includes != null)
					{
						this.Packages.AddRange(this.Includes);
					}
				}
				return packages;
			}
		}

		/// <summary>
		/// optional html to use as the container.
		/// </summary>
		private string WidgetHtml { get; set; }

		/// <summary>
		/// the class name for the widget.
		/// </summary>
		private string WidgetClass { get; set; }

		/// <summary>
		/// The script used to initialize the widget
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override string InitScript
		{
			// disable inlining or we lose the calling assembly in GetResourceString().
			[MethodImpl(MethodImplOptions.NoInlining)]
			get { return this.GetResourceString($"{NAMESPACE}.{this.GetControlType().Name}"); }
			set { }
		}

		/// <summary>
		/// The JS functions used in the widget
		/// </summary>
		[DefaultValue(null)]
		public WidgetFunction[] WidgetFunctions
		{
			get;
			set;
		}

		/// <summary>
		/// The widget event handlers.
		/// </summary>
		[DefaultValue(null)]
		public WidgetEventHandler[] WidgetEvents
		{
			get;
			set;
		}

		/// <summary>
		/// The templates used by the widget
		/// </summary>
		[DefaultValue(null)]
		public WidgetTemplate[] WidgetTemplates
		{
			get;
			set;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Returns the type derived from igBase.
		/// </summary>
		private Type GetControlType()
		{
			var type = this.GetType();
			while (type.BaseType != typeof(igBase) && type.BaseType != null)
			{
				type = type.BaseType;
			}
			return type;
		}

		/// <summary>
		/// Returns the Image encoded in a base64 string.
		/// </summary>
		/// <param name="base64">base64 string to convert to an image.</param>
		/// <returns>An <see cref="Image"/>.</returns>
		internal static Image ImageFromBase64(string base64)
		{
			// data:image/gif;base64,R0lGODlhCQAJAIABAAAAAAAAACH5BAEAAAEALAAAAAAJAAkAAAILjI+py+0NojxyhgIAOw==
			try
			{
				if (String.IsNullOrEmpty(base64))
					return null;

				int pos = base64.IndexOf("base64,");
				if (pos < 0)
					return null;

				base64 = base64.Substring(pos + 7);
				byte[] buffer = Convert.FromBase64String(base64);

				MemoryStream stream = new MemoryStream(buffer);
				return Image.FromStream(stream);
			}
			catch { }

			return null;
		}

		#endregion

		#region Wisej Implementation

		/// <summary>
		/// Designer timeout. The ignite library is a bit slow to
		/// load in the designer the first time.
		/// </summary>
		int IWisejControl.DesignerTimeout
		{
			get { return 30000; }
		}

		/// <summary>
		/// Wire the client config to the server
		/// </summary>
		/// <param name="config"></param>
		protected override void OnWebRender(dynamic config)
		{
			base.OnWebRender((object)config);

			config.className = "wisej.web.ext.IgniteWidget";
			config.widgetHtml = this.WidgetHtml;
			config.widgetClass = this.WidgetClass;
			config.widgetEvents = this.WidgetEvents;
			config.widgetFunctions = this.WidgetFunctions;
			config.widgetTemplates = this.WidgetTemplates;
		}

		#endregion

		#region WidgetTemplate

		/// <summary>
		/// Represents an Ignite template.
		/// </summary>
		/// <remarks>
		/// Templates in the Ignite library are either plain global JavaScript functions, or
		/// HTML snippets using their template syntax.
		/// </remarks>
		public class WidgetTemplate
		{
			/// <summary>
			/// The identifier of the <see cref="WidgetTemplate"/>
			/// </summary>
			[DefaultValue("")]
			public string Id
			{
				get { return this._id; }
				set
				{
					value = value ?? string.Empty;
					this._id = value;
				}
			}
			private string _id = string.Empty;

			/// <summary>
			/// The template used by the <see cref="WidgetTemplate"/>
			/// </summary>
			[DefaultValue("")]
			[Editor("Wisej.Design.HtmlEditor, Wisej.Framework.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=17bef35e11b84171", typeof(UITypeEditor))]
			public string Template
			{
				get { return this._template; }
				set
				{
					value = value ?? string.Empty;
					this._template = value;
				}
			}
			private string _template = string.Empty;

			/// <summary>
			/// Type of the template. Use "text/x-jsrender" for HTML templates or
			/// "text/javascript" for simpler javascript functions.
			/// </summary>
			[DefaultValue("text/x-jsrender")]
			public string Type
			{
				get { return this._type; }
				set
				{
					value = value ?? string.Empty;
					this._type = value;
				}
			}
			private string _type = "text/x-jsrender";

			/// <summary>
			/// String representation of <see cref="WidgetTemplate"/>
			/// </summary>
			/// <returns></returns>
			public override string ToString()
			{
				return this.Id ?? SR.GetString("toStringNone");
			}

		}

		#endregion

		#region WidgetEventHandler

		/// <summary>
		/// Represents a JavScript handler attached to an event fired by the
		/// third party widget.
		/// </summary>
		/// <remarks>
		/// Refer to "this" in the context of the function to target the wisej.web.Widget instance, and to
		/// "this.widget" to refer to the third party widget.
		/// </remarks>
		public class WidgetEventHandler
		{
			/// <summary>
			/// The name of the <see cref="WidgetEventHandler"/>
			/// </summary>
			[DefaultValue("")]
			public string Name
			{
				get { return this._name; }
				set
				{
					value = value ?? string.Empty;
					this._name = value;
				}
			}
			private string _name = string.Empty;

			/// <summary>
			/// The source code of the <see cref="WidgetEventHandler"/>
			/// </summary>
			[Editor("Wisej.Design.CodeEditor, Wisej.Framework.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=17bef35e11b84171", typeof(UITypeEditor))]
			public string Source
			{
				get { return this._source; }
				set
				{
					value = value ?? string.Empty;
					this._source = value;
				}
			}
			private string _source = string.Empty;

			/// <summary>
			/// Gets the string representation of <see cref="WidgetEventHandler"/>
			/// </summary>
			/// <returns></returns>
			public override string ToString()
			{
				return this.Name ?? SR.GetString("toStringNone");
			}
		}

		#endregion

		#region WidgetFunction

		/// <summary>
		/// Represents a JavaScript function attached to the widget on the browser.
		/// </summary>
		/// <remarks>
		/// Refer to "this" in the context of the function to target the wisej.web.Widget instance, and to
		/// "this.widget" to refer to the third party widget.
		/// </remarks>
		public class WidgetFunction
		{
			/// <summary>
			/// The name of the <see cref="WidgetFunction"/>
			/// </summary>
			[DefaultValue("")]
			public string Name
			{
				get { return this._name; }
				set
				{
					value = value ?? string.Empty;
					this._name = value;
				}
			}
			private string _name = string.Empty;

			/// <summary>
			/// The source code for the <see cref="WidgetFunction"/>
			/// </summary>
			[Editor("Wisej.Design.CodeEditor, Wisej.Framework.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=17bef35e11b84171", typeof(UITypeEditor))]
			public string Source
			{
				get { return this._source; }
				set
				{
					value = value ?? string.Empty;
					this._source = value;
				}
			}
			private string _source = string.Empty;

			/// <summary>
			/// String representation of <see cref="WidgetFunction"/>
			/// </summary>
			/// <returns></returns>
			public override string ToString()
			{
				return this.Name ?? SR.GetString("toStringNone");
			}
		}

		#endregion
	}
}