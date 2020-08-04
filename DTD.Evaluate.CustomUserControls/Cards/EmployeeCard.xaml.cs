using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using DTD.Evaluate.Models.DataModels;
using MaterialDesignThemes.Wpf;

namespace DTD.Evaluate.CustomUserControls.Cards
{
    /// <summary>
    /// Interaction logic for EmployeeCard.xaml
    /// </summary>
    public partial class EmployeeCard : UserControl
    {
        private User User { get; set; }
        public EmployeeCard(User user)
        {
            User = user;
            InitializeComponent();
            Namelable.Text = User.Name;
            
            ChipsPanel.Children.Clear();
            
            foreach (var category in user.Tags)
            {
                foreach (var data in category.Data)
                {
                    Chip chip=new Chip();
                    chip.Content = data.Name;
                    chip.Background=Brushes.Black;
                    chip.Foreground=Brushes.White;
                    chip.Margin=new Thickness(5);
                    ChipsPanel.Children.Add(chip);
                }
            }
        }

        private void BaseCard_MouseEnter(object sender, MouseEventArgs e)
        {
            BaseCard.SetValue(ShadowAssist.ShadowDepthProperty, ShadowDepth.Depth4);
        }

        private void BaseCard_MouseLeave(object sender, MouseEventArgs e)
        {
            BaseCard.SetValue(ShadowAssist.ShadowDepthProperty, ShadowDepth.Depth2);
        }
    }
}
