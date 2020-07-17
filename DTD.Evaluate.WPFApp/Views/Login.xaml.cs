using System;
using System.IO;
using System.Windows;
using DTD.Evaluate.APIManager;
using DTD.Evaluate.CustomUserControls.Dialogues;
using DTD.Evaluate.Models.ViewModels;
using MaterialDesignThemes.Wpf;
using Newtonsoft.Json;

namespace DTD.Evaluate.WPFApp
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
        private LoginViewModel _loginViewModel;
        private readonly string _rememberMeFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RememberMe.txt");

        public Login()
        {
            InitializeComponent();
            _loginViewModel = new LoginViewModel();
            if (RememberMeToggle.IsChecked == true) RememberMeLoad();
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            
            _loginViewModel.CompanyDomain = DomainBox.Text;
            _loginViewModel.Email = EmailBox.Text;
            _loginViewModel.Password = PasswordBox.Password;
            if (RememberMeToggle.IsChecked == true) RememberMeSave();
            EndPoints.BaseURL = _loginViewModel.CompanyDomain;

            //todo call api
            //DialogHost.Show(new LoadingSpinnerDialogue());


            var dashboardWindow = new Dashboard();

            dashboardWindow.Show();
        }

        private void RememberMeSave()
        {
            var data = JsonConvert.SerializeObject(_loginViewModel);
            File.WriteAllText(_rememberMeFile, data);
        }

        private void RememberMeLoad()
        {
            if (!File.Exists(_rememberMeFile)) return;
            var data = File.ReadAllText(_rememberMeFile);
            _loginViewModel = JsonConvert.DeserializeObject<LoginViewModel>(data);
            DomainBox.Text = _loginViewModel.CompanyDomain;
            EmailBox.Text = _loginViewModel.Email;
            PasswordBox.Password = _loginViewModel.Password;
        }
    }
}