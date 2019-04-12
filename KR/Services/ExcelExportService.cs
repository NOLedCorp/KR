using KR.Controllers;
using KR.Models;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Services
{

    class ExcelExportService
    {
        private Application excelapp;
        private Worksheet excelworksheet;
        private RentCarController _ctrl;
        private string fileName = System.Windows.Forms.Application.StartupPath + "\\Statistics.xlsx";

        public ExcelExportService()
        {
            Open();
        }

        private void Open()
        {
            excelapp = new Application();
            excelapp.Visible = false;
            excelapp.Workbooks.Open(fileName);
        }

        public void Show(List<CarRating> rc, RentCarController ctrl)
        {
            _ctrl = ctrl;
            ShowProfit();
            ShowRating();
            excelapp.Visible = true;
        }

        private void ShowRating()
        {
            excelworksheet = (Worksheet)excelapp.Worksheets.get_Item(4);
            var cars = _ctrl.GetCars();
            for (int m = 0; m < cars.Count; m++)
            {
                var excelcells = (Range)excelworksheet.Cells[m+2, 1];
                //выводим координаты ячеек
                excelcells.Value2 = cars[m].Model;
                excelcells = (Range)excelworksheet.Cells[m+2, 2];
                var marks = _ctrl.GetCarMarks(cars[m].CarId);
                if (marks.Count > 0)
                {
                    excelcells.Value2 = marks.Average();
                }
                else
                {
                    excelcells.Value2 = 0;
                }
                
            }
        }

        private void ShowProfit()
        {
            excelworksheet = (Worksheet)excelapp.Worksheets.get_Item(3);
            var year = DateTime.Now.Year;
            for (int m = 2; m < 13; m++)
            {
                var date1 = new DateTime(year, m-1, 1);
                var date2 = new DateTime(year, m, 1);
                var excelcells = (Range)excelworksheet.Cells[m, 1];
                //выводим координаты ячеек
                excelcells.Value2 = date2.ToShortDateString();
                excelcells = (Range)excelworksheet.Cells[m, 2];
                excelcells.Value2 = _ctrl.GetB().Where(x => x.DateStart<date2 && x.DateStart>date1).Select(x => x.Car.Price*(x.DateFinish-x.DateStart).Days).Sum();
            }
        }

    }
}
