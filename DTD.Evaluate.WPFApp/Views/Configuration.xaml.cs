using System.Windows;
using System.Windows.Controls;
using DTD.Evaluate.CustomUserControls.Cards;

namespace DTD.Evaluate.WPFApp
{
    /// <summary>
    /// Interaction logic for Configuration.xaml
    /// </summary>
    public partial class Configuration : UserControl
    {
        public Configuration()
        {
            InitializeComponent();
            UIInit();
           

        }

        private void UIInit()
        {
            TagManagerControl evaluationControl = new TagManagerControl
            {
                HeaderText = { Text = "Evaluation Criteria" },
                Margin = new Thickness(10),
                MinHeight = 200,
                MaxHeight = 350
            };


            TagManagerControl tagsControl = new TagManagerControl
            {
                HeaderText = { Text = "Tags" },
                Margin = new Thickness(10),
                MinHeight = 100,

            };

            tagsControl.SetValue(Grid.RowProperty, 1);

            MainGrid.Children.Add(evaluationControl);
            MainGrid.Children.Add(tagsControl);
        }

    }
}
