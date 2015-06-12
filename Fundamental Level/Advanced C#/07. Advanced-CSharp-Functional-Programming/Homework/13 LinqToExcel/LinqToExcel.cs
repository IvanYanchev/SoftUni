using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using OfficeOpenXml;

namespace LinqToExcel
{
    class LinqToExcel
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            using (var reader = new StreamReader("../../Students-data.txt"))
            {
                while (true)
                {
                    string inputLine = reader.ReadLine();
                    if (inputLine == null)
                    {
                        break;
                    }
                    try
                    {
                        string[] data = inputLine.Split('\t');
                        students.Add(new Student(int.Parse(data[0]), data[1], data[2], data[3], data[4], data[5], double.Parse(data[6]), double.Parse(data[7]), double.Parse(data[8]), double.Parse(data[9]), double.Parse(data[10]), double.Parse(data[11])));
                    }
                    catch (Exception)
                    {
                        
                    }

                }
            }

            var onlineStudents =
                from student in students
                where student.StudentType.Equals("Online")
                orderby student.Result descending
                select student;

            string excelOutputFilename = "../../Result.xlsx";
            System.IO.FileInfo newFile = new FileInfo(excelOutputFilename);
            if (newFile.Exists)
            {
                newFile.Delete();
            }
            ExcelPackage package = new ExcelPackage(newFile);	

            using (package)
            {
                
                ExcelWorksheet ws = package.Workbook.Worksheets.Add("Online Students");
                
                ws.Cells[1, 1].Value = "ID";
                ws.Cells[1, 2].Value = "First name";
                ws.Cells[1, 3].Value = "Last Name";
                ws.Cells[1, 4].Value = "Email";
                ws.Cells[1, 5].Value = "Gender";
                ws.Cells[1, 6].Value = "Student type";
                ws.Cells[1, 7].Value = "Exam result";
                ws.Cells[1, 8].Value = "Homework sent";
                ws.Cells[1, 9].Value = "Homework evaluated";
                ws.Cells[1, 10].Value = "Teamwork";
                ws.Cells[1, 11].Value = "Attendances";
                ws.Cells[1, 12].Value = "Bonus";
                ws.Cells[1, 13].Value = "Result";

                int row = 2;
                foreach (var student in onlineStudents)
                {
                    ws.Cells[row, 1].Value = student.ID;
                    ws.Cells[row, 2].Value = student.FirstName;
                    ws.Cells[row, 3].Value = student.LastName;
                    ws.Cells[row, 4].Value =student.Email;
                    ws.Cells[row, 5].Value = student.Gender;
                    ws.Cells[row, 6].Value = student.StudentType;
                    ws.Cells[row, 7].Value = student.ExamResult;
                    ws.Cells[row, 8].Value = student.HomeworkSent;
                    ws.Cells[row, 9].Value = student.HomeworkEvaluated;
                    ws.Cells[row, 10].Value = student.TeamworkScore;
                    ws.Cells[row, 11].Value = student.AttendancesCount;
                    ws.Cells[row, 12].Value = student.Bonus;
                    ws.Cells[row, 13].Value = student.Result;
                    row++;
                }
                ws.Cells.AutoFitColumns(0);
                package.Save();
            }
        }
    }
}
