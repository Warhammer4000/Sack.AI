using System.Windows;
using System.Windows.Controls;
using MaterialDesignThemes.Wpf;

namespace DTD.Evaluate.CustomUserControls.Cards
{
    /// <summary>
    /// Interaction logic for TagCard.xaml
    /// </summary>
    public partial class TagCard : UserControl
    {
        public TagCard()
        {
            InitializeComponent();
        }

        private void DialogHost_OnDialogClosing(object sender, DialogClosingEventArgs eventArgs)
        {
            if (!Equals(eventArgs.Parameter, true)) return;

            if (!string.IsNullOrWhiteSpace(CriteriaBox.Text))
            {
                Chip chip = new Chip()
                {
                    Margin = new Thickness(10),
                    IsDeletable = true,
                    Content = CriteriaBox.Text,
                    
                };
                chip.DeleteClick += Chip_DeleteClick;
                ItemsListBox.Children.Add(chip);
                CriteriaBox.Text = "";
            }
        }

        private void Chip_DeleteClick(object sender, RoutedEventArgs e)
        {
            ItemsListBox.Children.Remove((Chip)sender);
        }
    }
}
