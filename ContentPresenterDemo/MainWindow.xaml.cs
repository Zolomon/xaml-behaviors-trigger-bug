namespace ContentPresenterDemo
{
    using System.Collections.Generic;
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new List<ItemViewModel>
                          {
                              new ItemViewModel { Value = 1 }, 
                              new ItemViewModel { Value = 2 }, 
                              new ItemViewModel { Value = 3 }
                          };
        }
    }
}
