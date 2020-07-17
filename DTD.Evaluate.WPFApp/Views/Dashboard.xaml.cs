using DTD.Evaluate.WPFApp.ViewPages;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DTD.Evaluate.CustomUserControls.Dialogues;

namespace DTD.Evaluate.WPFApp
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void QuitButtonPress(object sender, RoutedEventArgs e)
        {
            var dialoguebox = new DialogueBox(" Are You Sure you wish to quit?");
            dialoguebox.Owner = this;
            dialoguebox.OnCancleButtonClick += ()=> dialoguebox.Close();
            dialoguebox.OnOkButtonClick += () => Application.Current.Shutdown();
            dialoguebox.ShowDialog();
           
           
        }

        

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);

            UserControl panel = null;
            ContentGrid.Children.Clear();
            switch (index)
            {
                case 0:
                   
                    panel=new UserProfile();
                    break;
                case 1:
                    panel = new EmployeesView();
                    break;
                case 2:
                    panel = new ComparisionPage();
                    break;
                case 3:
                    panel = new Configuration();
                    break;
                default:
                    break;
            }

            if (panel != null)
            {
                ContentGrid.Children.Add(panel);
            }

        }

        private void MoveCursorMenu(int index)
        {
            TrainsitionigContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, ((60 * index)), 0, 0);
        }

     

        private void WindowStateButton_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                WindowState = WindowState.Normal;
            }
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
