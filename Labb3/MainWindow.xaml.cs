using System.Windows;

namespace GymBookingSystem
{
    public partial class MainWindow : Window
    {
        private Bokningshantering bokningshantering;

        public MainWindow()
        {
            InitializeComponent();
            bokningshantering = new Bokningshantering();
            PassListView.ItemsSource = bokningshantering.PassLista;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string sökTerm = SearchBox.Text;
            PassListView.ItemsSource = bokningshantering.SökPass(sökTerm);
        }

        private void BokaButton_Click(object sender, RoutedEventArgs e)
        {
            if (PassListView.SelectedItem is Pass selectedPass && selectedPass.AntalPlatser > 0)
            {
                selectedPass.AntalPlatser--;
                PassListView.ItemsSource = null; // Refresh the list
                PassListView.ItemsSource = bokningshantering.PassLista;
                MessageBox.Show("Bokning genomförd!");
            }
            else
            {
                MessageBox.Show("Passet är fullbokat eller inget pass är valt.");
            }
        }

        private void AvbokaButton_Click(object sender, RoutedEventArgs e)
        {
            if (PassListView.SelectedItem is Pass selectedPass)
            {
                selectedPass.AntalPlatser++;
                PassListView.ItemsSource = null; // Refresh the list
                PassListView.ItemsSource = bokningshantering.PassLista;
                MessageBox.Show("Avbokning gjord!");
            }
            else
            {
                MessageBox.Show("Inget pass är valt för avbokning.");
            }
        }
    }
}

