using System.Windows;

namespace DTD.Evaluate.CustomUserControls.Dialogues
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
