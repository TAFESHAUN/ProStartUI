using System.Configuration;
using System.Windows;
using ProStartUI.DataModel;
using ProStartUI.Repositories;

namespace ProStartUI
{
    public partial class MainWindow : Window
    {
        private readonly IRepo _repo;
        public MainWindow()
        {
            InitializeComponent();

            string connStr = "Data Source=DESKTOP-FFSLR8G\\SQLEXPRESS01;Initial Catalog=ActivitiesDb;Integrated Security=True;Trust Server Certificate=True";

            _repo = new ActivityRepoDB(connStr);
        }

        private void DisplayAll_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                List<Activity> activities = _repo.GetAllActivities();
                ResultsGrid.ItemsSource = activities;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Could not load activities:\n{ex.Message}",
                    "Database Error",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        // Add event handlers to buttons > Add, Update, Search (check your stored procedures & repo methods)
        //Example search click event here
        private void SearchActivities_Click(object sender, RoutedEventArgs e)
        {
            //Call DB search here

        }

    }
}