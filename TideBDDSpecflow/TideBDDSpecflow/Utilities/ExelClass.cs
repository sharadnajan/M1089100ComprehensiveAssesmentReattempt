using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TideBDDSpecflow.Utilities
{
    public class ExelClass
    {
        public static string ExcelRead()
        {
            String path = @"C:\Users\mindc1may134\Desktop\Comprehensive_M_1089100\TideBDDSpecflow\ExelRead.xlsx";
            XSSFWorkbook workbook = new XSSFWorkbook(File.Open(path, FileMode.Open));
            var sheet = workbook.GetSheetAt(0).GetRow(1).GetCell(1).StringCellValue.Trim();
            Console.WriteLine("The Data in the ExcelSheet is :" + sheet);
            return sheet;
        }
    }
}
