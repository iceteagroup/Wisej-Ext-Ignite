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
	/// <summary>
	/// The igSpreadsheet control allows visualization of spreadsheet data, 
	/// represented by the data model supported by the Infragistics Javascript 
	/// Excel Library comprising of Workbooks, Worksheets, Cells, Formulas and more.
	/// </summary>
	public class igSpreadsheet : igBase
	{

		#region Constructors

		/// <summary>
		/// Constructs a new instance of the <see cref="igSpreadsheet"/> class.
		/// </summary>
		public igSpreadsheet() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igSpreadsheet"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igSpreadsheet(object options) : base("igSpreadsheet", options)
		{
			this.WidgetWiredEvents = new[] {
			"actionExecuted",
			"actionExecuting",
			"activeCellChanged",
			"activePaneChanged",
			"activeTableChanged",
			"activeWorksheetChanged",
			"contextMenuOpening",
			"editModeEntered",
			"editModeEntering",
			"editModeExited",
			"editModeValidationError",
			"editRangePasswordNeeded",
			"hyperlinkExecuting",
			"selectionChanged",
			"userPromptDisplaying",
			"workbookDirtied"
			};
		}

		#endregion

		#region Widget Properties

		/// <summary>
		/// Specifies the active cell of the current worksheet
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public string ActiveCell
		{
			get
			{
				return this.Options.activeCell;
			}
			set
			{
				if (this.Options.activeCell != value)
					this.Options.activeCell = value;
			}
		}

		/// <summary>
		/// Returns or sets a boolean indicating if the formula bar is displayed within the Spreadsheet.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public bool IsFormulaBarVisible
		{
			get
			{
				return this.Options.isFormulaBarVisible ?? true;
			}
			set
			{
				if (this.Options.isFormulaBarVisible != value)
					this.Options.isFormulaBarVisible = value;
			}
		}

		/// <summary>
		/// Returns or sets a boolean indicating whether a fixed decimal place is automatically added when a whole number is entered while in edit mode.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public bool IsFixedDecimalEnabled
		{
			get
			{
				return this.Options.isFixedDecimalEnabled ?? false;
			}
			set
			{
				if (this.Options.isFixedDecimalEnabled != value)
					this.Options.isFixedDecimalEnabled = value;
			}
		}

		/// <summary>
		/// Returns or sets a boolean indicating whether the adjacent cell indicated 
		/// by the enterKeyNavigationDirection should be navigated to when the enter key is pressed.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public bool IsEnterKeyNavigationEnabled
		{
			get
			{
				return this.Options.isEnterKeyNavigationEnabled ?? false;
			}
			set
			{
				if (this.Options.isEnterKeyNavigationEnabled != value)
					this.Options.isEnterKeyNavigationEnabled = value;
			}
		}

		/// <summary>
		/// Returns or sets a boolean indicating whether the scroll lock key is toggled.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public bool IsScrollLocked
		{
			get
			{
				return this.Options.isScrollLocked ?? false;
			}
			set
			{
				if (this.Options.isScrollLocked != value)
					this.Options.isScrollLocked = value;
			}
		}

		/// <summary>
		/// Returns or sets a value indicating how the selection is updated when interacting with the cells via the mouse or keyboard.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public SelectionModes SelectionMode
		{
			get
			{
				return this._selectionMode;
			}
			set
			{
				if (this.Options.selectionMode != value)
				{
					this.Options.selectionMode = Enum.GetName(typeof(SelectionModes), value);
					this._selectionMode = value;
				}
			}
		}
		private SelectionModes _selectionMode = SelectionModes.normal;

		/// <summary>
		/// Returns or sets the width of the name box within the formula bar.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public int NameBoxWidth
		{
			get
			{
				return this.Options.nameBoxWidth ?? 102;
			}
			set
			{
				if (this.Options.nameBoxWidth != value)
					this.Options.nameBoxWidth = value;
			}
		}

		#endregion

		#region SelectionModes

		public enum SelectionModes
		{
			/// <summary>
			/// The selection is replaced when dragging the mouse to select a cell or range of cells.
			/// </summary>
			normal,

			/// <summary>
			/// The selection range in the cellRanges representing the active cell is updated as one uses the mouse to 
			/// select a cell or navigating via the keyboard.
			/// </summary>
			extendSelection,

			/// <summary>
			/// New cell ranges are added to the cellRanges without needing to hold down the ctrl key when dragging via the mouse 
			/// and a range is added with the first arrow key navigation after entering the mode. One can enter the mode by pressing Shift+F8.
			/// </summary>
			addToSelection
		}

		#endregion
	}
}
