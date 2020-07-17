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

namespace DTD.Evaluate.WPFApp.Views
{
    /// <summary>
    /// Interaction logic for DialogueBox.xaml
    /// </summary>
    public partial class DialogueBox : Window
    {
        public delegate void ButtonEvent();

        public ButtonEvent OnOkButtonClick;
        public ButtonEvent OnCancleButtonClick;

        public DialogueBox(string message)
        {
            InitializeComponent();
            MessageBlock.Text = message;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            OnOkButtonClick?.Invoke();
        }

        private void CancleButton_Click(object sender, RoutedEventArgs e)
        {
            OnCancleButtonClick?.Invoke();
        }
    }
}
