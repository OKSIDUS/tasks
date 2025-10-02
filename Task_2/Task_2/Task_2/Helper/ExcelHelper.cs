using ClosedXML.Excel;
using System.Data;

namespace Task_2.Helper
{
    public static class ExcelHelper
    {
        public static DataTable ReadExcelToDataTable(string filePath)
        {
            var dt = new DataTable();

            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheets.Worksheet(1); 
                var range = worksheet.RangeUsed();

                foreach (var firstRowCell in range.FirstRow().Cells())
                {
                    dt.Columns.Add(firstRowCell.Value.ToString());
                }

                foreach (var row in range.RowsUsed().Skip(1)) 
                {
                    var dataRow = dt.NewRow();
                    for (int i = 0; i < row.Cells().Count(); i++)
                    {
                        dataRow[i] = row.Cell(i + 1).Value.ToString();
                    }
                    dt.Rows.Add(dataRow);
                }
            }

            return dt;
        }


        /*
         * 
         * Читать только четные ряды
         * Сперва читаем ряд с именем столбцов, а после выводим 2 ряд, 4 ряд и т.д.
         * 
         * 
         */
        public static DataTable ReadOnlyOddRow(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
