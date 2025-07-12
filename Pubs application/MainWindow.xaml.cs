using System;
using System.Windows;
using Pubs_application.Views;
using Pubs_application.Modals;
using System.Windows.Controls;
using System.ComponentModel;


namespace Pubs_application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Views.GridView gridView;
        public MainWindow()
        {
            this.gridView = new Views.GridView();
            handleAuthorsView(this, null); 
        }

        private void handleAuthorsView(object sender, RoutedEventArgs args)
        {
            this.gridView.SetAuthorsData();
            this.DataContext = this.gridView;
        }

        private void handlePublishersView(object sender, RoutedEventArgs args)
        {
            this.gridView.SetPublishersData();
            this.DataContext = this.gridView;
        }

        private void handleTitlesView(object sender, RoutedEventArgs args)
        {
            this.gridView.SetTitlesData();
            this.DataContext = this.gridView;
        }

        private void openAuthorsModal(object sender, RoutedEventArgs args)
        {
            Window authorsModal = new AuthorsModal();
            authorsModal.Owner = this;
            authorsModal.Show();
        }
    }
}