
using System.Windows;

using DTD.Evaluate.WPFApp.Views;

namespace DTD.Evaluate.WPFApp.ViewPages
{
    /// <summary>
    /// Interaction logic for NewEmployee.xaml
    /// </summary>
    public partial class NewEmployee : Window
    {
        public DialogueBox.ButtonEvent OnCreateEmployee;
        public NewEmployee()
        {
            InitializeComponent();
            
        }

     

      

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            OnCreateEmployee?.Invoke();
            Close();
        }

        private void CancleButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
