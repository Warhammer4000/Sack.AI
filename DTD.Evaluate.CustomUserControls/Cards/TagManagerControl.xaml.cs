using System.Windows;
using System.Windows.Controls;
using MaterialDesignThemes.Wpf;

namespace DTD.Evaluate.CustomUserControls.Cards
{
    /// <summary>
    /// Interaction logic for TagManagerControl.xaml
    /// </summary>
    public partial class TagManagerControl : UserControl
    {
        public TagManagerControl()
        {
            InitializeComponent();
        }

      

        private void DialogHost_OnDialogClosing(object sender, DialogClosingEventArgs eventArgs)
        {
            if (!Equals(eventArgs.Parameter, true)) return;

            if (!string.IsNullOrWhiteSpace(CategoryNameTextBox.Text))
            {
                TagCard tagCard = new TagCard
                {
                    Margin = new Thickness(10), 
                    CategoryLabel = {Text = CategoryNameTextBox.Text}
                };
                ContentPanel.Children.Add(tagCard);
                CategoryNameTextBox.Text = "";
            }
               
        }
    }
}
