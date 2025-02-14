namespace WPFGanttSample
{
    using Syncfusion.SfSkinManager;
    using Syncfusion.UI.Xaml.TreeGrid;
    using Syncfusion.Windows.Controls.Gantt;
    using System.Collections.ObjectModel;
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SfSkinManager.SetTheme(this, new Theme("Material3Light"));
        }
    }
}