//using System;
//using System.Collections.Generic;
//using Excel = Microsoft.Office.Interop.Excel;

//namespace Students
//{
//  class ExelWorker
//  {
//    public void ExportToExcel(List<ReceivedGroup> students)
//    {
//      Excel.Application excelApp = new Excel.Application();
//      excelApp.Visible = true;
//      excelApp.Workbooks.Add();
//      Excel._Worksheet workSheet = excelApp.ActiveSheet;
//      workSheet.Cells[1, "A"] = "ФИО\nстудента";
//      workSheet.Cells[1, "B"] = "Балл";
//      workSheet.Cells[2, "C"] = "промежуточный";
//      workSheet.Cells[2, "D"] = "экзамнационный";
//      workSheet.Cells[2, "E"] = "итоговый";
//      int iLastRow = workSheet.Cells[workSheet.Rows.Count, "A"].End[Excel.XlDirection.xlUp].Row;// the last filled row in column A      
//      foreach (ReceivedGroup student in students)
//      {
//        iLastRow++;
//        workSheet.Cells[iLastRow, "A"].Value = students.SecondName;
//        workSheet.Cells[iLastRow, "B"].Value = car.Year;
//        workSheet.Cells[iLastRow, "C"].Value = car.Cost;
//        workSheet.Cells[iLastRow, "D"].Value = car.Description;
//        workSheet.Cells[iLastRow, "E"].Value = car.DescriptionFromSalesman;
//        workSheet.Cells[iLastRow, "F"].Value = car.Link;
//      }
//      excelApp.DisplayAlerts = false;
//      workSheet.SaveAs(string.Format(@"{0}\Cars.xlsx", Environment.CurrentDirectory));
//      excelApp.Quit();
//    }
//  }
//}
