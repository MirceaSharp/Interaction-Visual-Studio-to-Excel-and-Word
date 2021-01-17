using System;
using System.Windows;
using Word = Microsoft.Office.Interop.Word;

namespace Interactie_met_andere_applicaties {
	/// <summary>
	/// Interaction logic for FrmWord.xaml
	/// </summary>
	public partial class FrmWord : Window {
		public FrmWord( ) {
			InitializeComponent( );
		}

		private void btnAfdrukken_Click(object sender, RoutedEventArgs e) {
			Word.Application wordApp = null;
			try {
				// Word starten en sjabloon laden
				wordApp = new Word.Application( );
				Word.Document wordDoc = wordApp.Documents.Add(Environment.CurrentDirectory + @"\Attest.dotx");
				// alle bookmarks doorlopen en de juiste invullen
				foreach (Word.Bookmark bm in wordDoc.Bookmarks) {
					switch (bm.Name) {
						case "naam": bm.Range.Text = txtNaam.Text; break;
					}
				}
				// document oplsaan en het ducument sluiten
				wordDoc.SaveAs(Environment.CurrentDirectory + @"\" + txtNaam.Text + ".docx");
				wordDoc.Close(true);
			} catch (Exception ex) {
				MessageBox.Show("Er is iets fout gelopen:" + ex.Message + Environment.NewLine + ex.StackTrace);
			} finally {
				// Word sluiten
				wordApp.Quit( );
			}
		}
	}
}

