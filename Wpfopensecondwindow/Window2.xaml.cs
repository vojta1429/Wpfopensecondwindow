using System.Windows;
using System.Windows.Input;

namespace Wpfopensecondwindow
{
    
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || lstNames.Items.Contains(txtName.Text))
            {
                return;
            }
            lstNames.Items.Add(txtName.Text);
            txtName.Clear();
        }
        

    }
}
