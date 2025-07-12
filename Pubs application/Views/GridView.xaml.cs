using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Pubs_application.Database;
using Pubs_application.ViewModels;


namespace Pubs_application.Views
{
    /// <summary>
    /// Interaction logic for GridView.xaml
    /// </summary>
    public partial class GridView : UserControl
    {
        private pubsEntities db = new pubsEntities();

        private DataGrid dataGrid;

        public BaseViewModel baseViewModel { get; set; }
        public GridView()
        {
            InitializeComponent();
            dataGrid = (DataGrid)this.FindName("MainDataGrid");
        }

        private void populateColumns()
        {
            dataGrid.Columns.Clear();
          
            foreach(KeyValuePair<string, string> column in baseViewModel.columns)
            {
                DataGridTextColumn col = new DataGridTextColumn();
                col.Header = column.Key;
                col.Binding = new Binding(column.Value);

                dataGrid.Columns.Insert(0, col);
            }

            createActionsColumn();
        }

        private void createActionsColumn()
        {
            FrameworkElementFactory deleteImage = new FrameworkElementFactory(typeof(Image));
            deleteImage.SetValue(Image.SourceProperty, new BitmapImage(new System.Uri("../../Img/Delete.png", UriKind.RelativeOrAbsolute)));

            FrameworkElementFactory editImage = new FrameworkElementFactory(typeof(Image));            
            editImage.SetValue(Image.SourceProperty, new BitmapImage(new System.Uri("../../Img/Edit.png", UriKind.RelativeOrAbsolute)));

            FrameworkElementFactory editButton = new FrameworkElementFactory(typeof(Button));
            editButton.AppendChild(editImage); 
            editButton.SetValue(Button.BackgroundProperty, Brushes.Transparent);
            

            FrameworkElementFactory deleteButton = new FrameworkElementFactory(typeof(Button));
            deleteButton.SetValue(Button.BackgroundProperty, Brushes.Transparent);
            deleteButton.AppendChild(deleteImage);

            FrameworkElementFactory actionsStackPanel = new FrameworkElementFactory(typeof(StackPanel));
            actionsStackPanel.SetValue(StackPanel.OrientationProperty, Orientation.Horizontal);
            actionsStackPanel.SetValue(StackPanel.HorizontalAlignmentProperty, HorizontalAlignment.Center);

            actionsStackPanel.AppendChild(editButton);
            actionsStackPanel.AppendChild(deleteButton);

            DataTemplate actionsDataTemplate = new DataTemplate();
            actionsDataTemplate.VisualTree = actionsStackPanel; 


            DataGridTemplateColumn actionsDataGridTemplateColumn = new DataGridTemplateColumn();
            actionsDataGridTemplateColumn.CellTemplate = actionsDataTemplate;
            actionsDataGridTemplateColumn.Header = "Actions";
            
            dataGrid.Columns.Add(actionsDataGridTemplateColumn);
        }

        public void SetAuthorsData()
        {
            this.baseViewModel = new AuthorsViewModel();
            dataGrid.ItemsSource = db.authors.ToList();
            populateColumns();
        }

        public void SetPublishersData() {
            this.baseViewModel = new PublishersViewModel();
            dataGrid.ItemsSource = db.publishers.ToList();
            populateColumns();
        }

        public void SetTitlesData() {
            this.baseViewModel = new TitleViewModel();
            dataGrid.ItemsSource = db.titles.ToList();
            populateColumns();
        }
    }
}
