using Avalonia.Controls;
using Avalonia.Interactivity;

namespace StudentIDCardApp
{
    public partial class WelcomeDialog : Window
    {
        public WelcomeDialog()
        {
            InitializeComponent();
        }

        // Custom constructor to pass the message
        public WelcomeDialog(string message) : this()
        {
            WelcomeMessageText.Text = message;
        }

        private void OnCloseClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
