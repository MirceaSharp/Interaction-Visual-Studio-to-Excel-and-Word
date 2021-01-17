using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Windows;
using Excel = Microsoft.Office.Interop.Excel;

namespace Interactie_met_andere_applicaties {
	/// <summary>
	/// Interaction logic for FrmExcel2.xaml
	/// </summary>
	public partial class FrmExcel2 : System.Windows.Window {
		public FrmExcel2( ) {
			InitializeComponent( );
		}

		private void btnInlezen_Click(object sender, RoutedEventArgs e) {
			Excel.Application xlApp = null;
			try {
				// Excel openen, document openen en eerste sheet nemen
				xlApp = new Excel.Application( );
				Workbook xlWorkbook = xlApp.Workbooks.Open(Environment.CurrentDirectory + @"\Cursisten.xlsx");
				Worksheet xlWorksheet = xlWorkbook.Sheets[1];

				// studenten uitlzezn en ze in een lijst zetten als ze het juiste geslacht hebben
				List<Student> listStudenten = new List<Student>();
				int i = 4;
				while (!string.IsNullOrEmpty(xlWorksheet.Cells[i, 1].value)) 
				{
					Student student = new Student(
						xlWorksheet.Cells[i, 1].value,	// naam
						xlWorksheet.Cells[i, 2].value,	// geslacht
						xlWorksheet.Cells[i, 3].value); // punten
					if (cbJongens.IsChecked == true && student.Geslacht == "M") listStudenten.Add(student);
					if (cbMeisjes.IsChecked == true && student.Geslacht == "V") listStudenten.Add(student);
					i += 1;
				}

				// listbox items updaten
				//lstCursisten.ItemsSource = null;
				lstCursisten.ItemsSource = listStudenten;

				// document sluiten
				xlWorkbook.Close(XlSaveAction.xlSaveChanges);
			} catch (Exception ex) {
				MessageBox.Show("Er is iets fout gelopen:" + ex.Message + Environment.NewLine + ex.StackTrace);
			} finally {
				// Excel sluiten
				xlApp.Quit( );
			}
		}

		private void btnGrafiek_Click(object sender, RoutedEventArgs e) {
			Excel.Application xlApp = null;
			try {
				// Excel openen, Excel bestand openen en het eerste sheet nemen.
				xlApp = new Excel.Application( );
				Workbook xlWorkbook = xlApp.Workbooks.Open(Environment.CurrentDirectory + @"\Cursisten.xlsx");
				Worksheet xlWorksheet = xlWorkbook.Sheets[1];

				// Grafiek aanmaken
				Chart chart = xlWorksheet.ChartObjects( ).Add(250, 30, 400, 250).Chart;

				// Data aan de grafiek geven
				int maxrij = xlWorksheet.UsedRange.Rows.Count;
				string xlListSerpatorStr = xlApp.International[XlApplicationInternational.xlListSeparator];
				Range chartRange = xlWorksheet.get_Range($"A3:A{maxrij}{xlListSerpatorStr}C3:C{maxrij}");
				chart.SetSourceData(chartRange);

				// instellingen van de grafiek aanpassne
				chart.HasLegend = true;
				chart.Legend.Position = XlLegendPosition.xlLegendPositionRight;
				chart.ChartType = XlChartType.xlLine;
				chart.HasTitle = true;
				chart.ChartTitle.Text = "Gebruik Office Applicaties";

				// titels can de assen zetten
				chart.Axes(XlAxisType.xlCategory).HasTitle = true;
				chart.Axes(XlAxisType.xlCategory).AxisTitle.Characters.Text = "Studenten";
				chart.Axes(XlAxisType.xlValue).HasTitle = true;
				chart.Axes(XlAxisType.xlValue).AxisTitle.Characters.Text = "Punten";

				// ducment oplsaan en het document sluiten
				xlWorkbook.SaveAs(Environment.CurrentDirectory + @"\test2.xlsx");
				xlWorkbook.Close( );
			} catch (Exception ex) {
				MessageBox.Show("Er is iets fout gelopen: " + ex.Message + Environment.NewLine + ex.StackTrace);
			} finally {
				// Excel sluiten
				xlApp.Quit( );
			}
		}

		private void btnSluiten_Click(object sender, RoutedEventArgs e) {
			Close( );
		}
	}
}
