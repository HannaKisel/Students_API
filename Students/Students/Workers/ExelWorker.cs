using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using Students.Essence;

namespace Students
{
  class ExelWorker
  {
    public void ExportToExcel(List<Student> group)
    {
      Excel.Application excelApp = new Excel.Application();
      excelApp.Visible = true;
      excelApp.Workbooks.Add();
      Excel._Worksheet workSheet = excelApp.ActiveSheet;
      workSheet.Cells[1, "A"] = "Дисциплина";
      workSheet.Cells[2, "A"] = "Преподаватель" + " " + group[0].CourseworkTeacher.SecondName + " " + group[0].CourseworkTeacher.FirstName;
      workSheet.Cells[3, "A"] = "Коэффициенты";
      workSheet.Cells[4, "A"] = "Факультет" + " " + group[0].Faculty;
      workSheet.Cells[5, "A"] = "Специальность" + " " + group[0].Specialty;
      workSheet.Cells[6, "A"] = "курс" + " " + group[0].Course + "Группа" + " " + group[0].Group;
      workSheet.Cells[7, "D"] = "";
      workSheet.Cells[8, "A"] = "ФИО\nстудента";
      workSheet.Cells[8, "B"] = "Промежуточный балл";
      workSheet.Cells[8, "C"] = "Экзаменационный балл";
      workSheet.Cells[8, "D"] = "Итоговый балл";
     
      int iLastRow = workSheet.Cells[workSheet.Rows.Count, "A"].End[Excel.XlDirection.xlUp].Row;// the last filled row in column A      
      foreach (Student student in group)
      {
        iLastRow++;
        workSheet.Cells[iLastRow, "A"].Value = student.SecondName + " " + student.FirstName + " " + student.MiddleName;
        workSheet.Cells[iLastRow, "B"].Value = student.LastSessionMark + 1;//add to student several mark
        workSheet.Cells[iLastRow, "C"].Value = student.LastSessionMark;//add to student exam mark
        workSheet.Cells[iLastRow, "D"].Value = student.LastSessionMark;// result mark
      }
      excelApp.DisplayAlerts = false;
      workSheet.SaveAs(string.Format(@"{0}\students.xlsx", Environment.CurrentDirectory));
      excelApp.Quit();
    }

    // private double GetAverageMark(int ) // describe method that calculate average mark
  }
}