using Penguins_Student_Management.JsonDatabase.Entity.Document;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Penguins_Student_Management.Controllers.ClassController
{
    partial class ClassController
    {
        public void ExportUser(Class @class, List<User> users)
        {
            DateTime time = DateTime.Now;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.Filter = "Excel Sheet|*.xls;*.xlsx|All Files(*.*)|*.*";
            saveFileDialog.FileName = String.Format("DS-{0:0000}{1:00}{2:00}{3:00}{4:00}{5:00}.xls", time.Year, time.Month, time.Day, time.Hour, time.Minute, time.Second);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook workbook = xlApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = null;

                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Test";

                worksheet.Cells[1, 1] = @class.Name;
                worksheet.Cells[1, 2] = @class.Faculty;
                worksheet.Cells[3, 1] = "Danh sách lớp";

                worksheet.Cells[4, 1] = "ID";
                worksheet.Cells[4, 2] = "Họ và tên";
                worksheet.Cells[4, 3] = "Giới tính";
                worksheet.Cells[4, 4] = "Ngày sinh";
                worksheet.Cells[4, 5] = "Dân tộc";
                worksheet.Cells[4, 6] = "Quê quán";
                worksheet.Cells[4, 7] = "Quốc tịch";
                worksheet.Cells[4, 8] = "Type";

                for (int i = 0; i < users.Count; i++)
                {
                    worksheet.Cells[i + 5, 1] = users[i].ID;
                    worksheet.Cells[i + 5, 2] = users[i].Name;
                    worksheet.Cells[i + 5, 3] = users[i].Gender;
                    worksheet.Cells[i + 5, 4] = users[i].Birthday;
                    worksheet.Cells[i + 5, 5] = users[i].Ethnic;
                    worksheet.Cells[i + 5, 6] = users[i].Hometown;
                    worksheet.Cells[i + 5, 7] = users[i].Nationality;
                    worksheet.Cells[i + 5, 8] = users[i].Type.ToString();
                }

                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                xlApp.Quit();
            }
        }
    }
}
