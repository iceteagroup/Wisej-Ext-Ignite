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


using System;
using System.ComponentModel;

namespace Wisej.Web.Ext.Ignite
{

	#region Constructors

	/// <summary>
	/// The igCombo is a full-featured combo box control.
	/// </summary>
	public class igCombo : igBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="igCombo"/> class.
		/// </summary>
		public igCombo() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igCombo"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igCombo(object options) : base("igCombo", options)
		{
			this.WidgetWiredEvents = new[] {
				"dataBinding",
				"dataBound",
				"dropDownClosed",
				"dropDownClosing",
				"dropDownOpened",
				"dropDownOpening",
				"filtered",
				"filtering",
				"selectionChanged",
				"selectionChanging"
			};
		}

		#endregion

		#region Widget Properties

		/// <summary>
		/// Gets/Sets condition used for highlighting of matching parts in items of drop-down list.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public HighlightMatchesModes HighlightMatchesMode
		{
			get
			{
				return this._highlightMatchesMode;
			}
			set
			{
				if (this._highlightMatchesMode != value) 
				{
					if (value == HighlightMatchesModes.nil) 
						this.Options.highlightMatchesMode = "null";
					else
						this.Options.highlightMatchesMode = Enum.GetName(typeof(HighlightMatchesModes), value);

					this._highlightMatchesMode = value;
				}
			}
		}
		private HighlightMatchesModes _highlightMatchesMode = HighlightMatchesModes.multi;

		/// <summary>
		/// Gets/Sets text in text input field
		/// </summary>
		public override string Text
		{
			get
			{
				return this.Options.text ?? "";
			}
			set
			{
				if (this.Options.text != value)
					this.Options.text = value;
			}
		}

		#endregion

		#region HighlightMatchesModes

		public enum HighlightMatchesModes {

			/// <summary>
			/// multiple matches in a single item are rendered.
			/// </summary>
			multi,

			/// <summary>
			/// match at any position in item is rendered.
			/// </summary>
			contains,

			/// <summary>
			/// only match which starts from the beginning of text is rendered.
			/// </summary>
			startsWith,

			/// <summary>
			/// only fully matched items are rendered.
			/// </summary>
			full,

			/// <summary>
			/// (Ignite UI equivalent of null) matches are not rendered.
			/// </summary>
			nil,
		}

		#endregion

		#region Widget Functions

		/// <summary>
		/// Gets/Sets index of active item in list.
		/// </summary>
		public void SetActiveIndex(int index)
		{
			this.Widget.activeIndex(index);
		}

		/// <summary>
		/// Deselects all selected items from the drop down list.
		/// </summary>
		public void DeselectAll()
		{
			this.Widget.deselectAll();
		}

		#endregion

	}
}