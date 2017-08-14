using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CrossCounting.Helpers
{
    public class ExportFileHelper
    {
        public static string ExportToExcel(string fileName, string directory, string extension, System.Data.DataTable dataTable)
        {
            if (dataTable == null || dataTable.Columns.Count == 0)
                throw new Exception("Error");

            // load excel, and create a new workbook
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Workbooks.Add();

            // single worksheet
            Microsoft.Office.Interop.Excel._Worksheet workSheet = excelApp.ActiveSheet;

            // column headings
            for (int i = 0; i < dataTable.Columns.Count; i++)
                workSheet.Cells[1, (i + 1)] = dataTable.Columns[i].ColumnName;

            // rows
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                // to do: format datetime values before printing
                for (int j = 0; j < dataTable.Columns.Count; j++)
                    workSheet.Cells[(i + 2), (j + 1)] = dataTable.Rows[i][j];
            }

            // check fielpath
            if (string.IsNullOrWhiteSpace(directory) || string.IsNullOrWhiteSpace(fileName))
                throw new Exception("Error");

            var result = string.Empty;
            var uploadPath = System.Web.Hosting.HostingEnvironment.MapPath(string.Format("{0}{1}", directory, fileName));

            if (!Directory.Exists(uploadPath))
                Directory.CreateDirectory(uploadPath);

            try
            {
                result = string.Format("{0}_{1}{2}", DateTime.Now.ToString("yyyyMMddHHmmss"), Guid.NewGuid(), extension);
                var file = Path.Combine(uploadPath, result).ToLower();

                workSheet.SaveAs(file);
                excelApp.Quit();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            excelApp.Visible = false;
            return string.Format("{0}{1}/{2}", directory, fileName, result);
        }

        public static string ToExcel(string fileName, string directory, string extension, System.Data.DataTable dataTable)
        {
            if (dataTable == null || dataTable.Columns.Count == 0)
                throw new Exception("Error");

            // check fielpath
            if (string.IsNullOrWhiteSpace(directory) || string.IsNullOrWhiteSpace(fileName))
                throw new Exception("Error");

            var result = string.Empty;
            var uploadPath = System.Web.Hosting.HostingEnvironment.MapPath(string.Format("{0}{1}", directory, fileName));

            if (!Directory.Exists(uploadPath))
                Directory.CreateDirectory(uploadPath);

            result = string.Format("{0}_{1}{2}", DateTime.Now.ToString("yyyyMMddHHmmss"), Guid.NewGuid(), extension);
            var file = Path.Combine(uploadPath, result).ToLower();

            FileInfo newFile = new FileInfo(file);
            if (newFile.Exists)
            {
                newFile.Delete();
                newFile = new FileInfo(file);
            }

            using (ExcelPackage pack = new ExcelPackage(newFile))
            {
                ExcelWorksheet ws = pack.Workbook.Worksheets.Add(result);
                ws.Cells["A1"].LoadFromDataTable(dataTable, true);
                pack.Save();
            }

            return string.Format("{0}{1}/{2}", directory, fileName, result);
        }
    }
}
