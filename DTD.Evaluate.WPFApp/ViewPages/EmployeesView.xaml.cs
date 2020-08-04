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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DTD.Evaluate.CustomUserControls.Cards;
using DTD.Evaluate.Factory;
using DTD.Evaluate.Factory.Interfaces;
using DTD.Evaluate.Models.DataModels;
using MaterialDesignThemes.Wpf;

namespace DTD.Evaluate.WPFApp.ViewPages
{
    /// <summary>
    /// Interaction logic for EmployeesView.xaml
    /// </summary>
    public partial class EmployeesView : UserControl
    {
        private IUserContext userContext;
        private List<User> users;
        public EmployeesView()
        {
            userContext = RepositoryManager.Instance.GetFactory().UserContext;
            users = userContext.GetAll();
            InitializeComponent();
            UpdateView();
        }


        public void UpdateView()
        {
            CardView.Children.Clear();
            foreach (var user in users)
            {
                EmployeeCard card = new EmployeeCard(user) {Margin = new Thickness(10)};
                CardView.Children.Add(card);
            }
        }



        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Window content = new NewEmployee();
            
            content.ShowDialog();
        }
    }
}
