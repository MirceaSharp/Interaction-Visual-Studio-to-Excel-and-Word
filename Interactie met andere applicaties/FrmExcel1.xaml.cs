using System;
using System.Windows;
using Excel = Microsoft.Office.Interop.Excel;

namespace Interactie_met_andere_applicaties {
	/// <summary>
	/// Interaction logic for FrmExcel1.xaml
	/// </summary>
	public partial class FrmExcel1 : Window {
		public FrmExcel1( ) {
			InitializeComponent( );
		}

		private void btnSluiten_Click(object sender, RoutedEventArgs e) {
			Close( );
		}

		private void btnBereken_Click(object sender, RoutedEventArgs e) {
			// Gegevens validatie
			string error = "";
			if (!double.TryParse(txtBedrag.Text, out double bedrag))
				error += "Geen numerieke waarde bij bedrag ingevuld!" + Environment.NewLine;
			if (!double.TryParse(txtTermijn.Text, out double termijn))
				error += "Geen numerieke waarde bij termijn ingevuld!" + Environment.NewLine;
			if (!double.TryParse(txtPercentage.Text, out double rentepercentage))
				error += "Geen numerieke waarde bij percentage ingevuld!" + Environment.NewLine;
			if (!string.IsNullOrEmpty(error)) {
				MessageBox.Show(error, "Fouten");
				return;
			}

			// Heir het echte werk
			Excel.Application xlapp = null;
			try {
				xlapp = new Excel.Application( );
				double teBetalen = Math.Abs(xlapp.WorksheetFunction.Pmt(rentepercentage, termijn, bedrag));
				txtTeBetalen.Text = teBetalen.ToString("c2");
			} catch (Exception ex) {
				MessageBox.Show("Er is iets fout gelopen:" + ex.Message + Environment.NewLine + ex.StackTrace);
			} finally {
				// Excel sluiten
				xlapp.Quit( );
			}
		}
	}
}
