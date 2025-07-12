
using System.Windows;

namespace Pubs_application.Modals
{
    /// <summary>
    /// Interaction logic for AuthorsModal.xaml
    /// </summary>
    public partial class AuthorsModal : Window
    {
        public AuthorsModal()
        {
            InitializeComponent();
        }
        private void closeWindow(object sender, RoutedEventArgs args)
        {
            Close();
        }
    }
}
