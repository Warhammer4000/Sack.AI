using System.Windows.Controls;
using System.Windows.Input;
using MaterialDesignThemes.Wpf;

namespace DTD.Evaluate.CustomUserControls.Cards
{
    /// <summary>
    /// Interaction logic for EmployeeCard.xaml
    /// </summary>
    public partial class EmployeeCard : UserControl
    {
        public EmployeeCard()
        {
            InitializeComponent();
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
