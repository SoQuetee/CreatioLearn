﻿namespace Terrasoft.Configuration.ExportToExcel
{
	using System;
	using System.IO;
	using System.Linq;
	using DocumentFormat.OpenXml.Packaging;
	using DocumentFormat.OpenXml.Spreadsheet;

	#region Class: ExcelStylesheetTemplateLoader

	/// <summary>
	/// Entity that loads stylesheet template.
	/// </summary>
	public class ExcelStylesheetTemplateLoader
	{
		#region Constants: Private

		private const string StylesheetTemplate =
						@"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"
				;

		#endregion

		#region Methods: Private

		private Cell GetCellTplByRowIndex(SheetData sheetData, int rowIndex) {
			var row = sheetData.Elements<Row>().FirstOrDefault(x => x.RowIndex == rowIndex);
			return row?.Elements<Cell>().First();
		}

		private CellFormat GetCellFormatByCell(Cell cell, SpreadsheetDocument templateDocument) {
			if (cell?.StyleIndex == null) {
				return null;
			}
			var cellFormat = new CellFormat();
			if (cell.StyleIndex.HasValue) {
				var tplCellFormat = templateDocument.WorkbookPart.WorkbookStylesPart.Stylesheet
						.CellFormats.ToList()[(int) cell.StyleIndex.Value] as CellFormat;
				cellFormat.FontId = tplCellFormat.FontId;
				cellFormat.FillId = tplCellFormat.FillId;
				cellFormat.BorderId = tplCellFormat.BorderId;
				cellFormat.FormatId = tplCellFormat.FormatId;
				cellFormat.Alignment = tplCellFormat.Alignment?.CloneNode(true) as Alignment;
				cellFormat.ApplyAlignment = tplCellFormat.ApplyAlignment;
			}
			return cellFormat;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Loads excel stylesheet template.
		/// </summary>
		/// <returns>Stylesheet template.</returns>
		public ExcelStylesheetTemplate LoadTemplate() {
			var byteArray = Convert.FromBase64String(StylesheetTemplate);
			var memoryStream = new MemoryStream(byteArray);
			var styleSheetTemplate = new ExcelStylesheetTemplate();
			using (SpreadsheetDocument templateDocument = SpreadsheetDocument.Open(memoryStream, true)) {
				var workbookPart = templateDocument.WorkbookPart.WorksheetParts.First();
				styleSheetTemplate.Stylesheet =
						templateDocument.WorkbookPart.WorkbookStylesPart.Stylesheet.CloneNode(true) as Stylesheet;
				var sheetData = workbookPart.Worksheet.GetFirstChild<SheetData>();
				var headerCell = GetCellTplByRowIndex(sheetData, 1);
				styleSheetTemplate.HeaderCellFormat = GetCellFormatByCell(headerCell, templateDocument);
				var valueCell = GetCellTplByRowIndex(sheetData, 2);
				styleSheetTemplate.ValueCellFormat = GetCellFormatByCell(valueCell, templateDocument);
			}
			return styleSheetTemplate;
		}

		#endregion
	}

	#endregion
}
