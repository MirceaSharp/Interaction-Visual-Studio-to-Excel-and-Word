using System.Windows;

namespace Interactie_met_andere_applicaties
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExcel1_Click(object sender, RoutedEventArgs e)
        {
            FrmExcel1 frm = new FrmExcel1();
            frm.Show();
        }

        private void btnExcel2_Click(object sender, RoutedEventArgs e)
        {
            FrmExcel2 frm = new FrmExcel2();
            frm.Show();
        }

        private void btnWord_Click(object sender, RoutedEventArgs e)
        {
            FrmWord frm = new FrmWord();
            frm.Show();
        }
    }
}
