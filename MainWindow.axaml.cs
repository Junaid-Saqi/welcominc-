using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace StudentIDCardApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void OnGenerateClick(object sender, RoutedEventArgs e)
        {
            string name = NameInput.Text?.Trim() ?? string.Empty;
            string department = DepartmentInput.Text?.Trim() ?? string.Empty;
            string semester = SemesterInput.Text?.Trim() ?? string.Empty;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(department) || string.IsNullOrEmpty(semester))
            {
                // Professional Error State (Subtle red)
                MessageBorder.Background = new SolidColorBrush(Color.Parse("#FEF2F2"));
                MessageBorder.BorderBrush = new SolidColorBrush(Color.Parse("#FECACA"));
                
                MessageIcon.Text = "!";
                MessageIcon.Foreground = new SolidColorBrush(Color.Parse("#DC2626"));
                
                MessageTitleText.Text = "Action Required";
                MessageTitleText.Foreground = new SolidColorBrush(Color.Parse("#991B1B"));

                MessageText.Text = "Please complete all fields (Name, Department, and Semester) before generating the welcome message.";
                MessageText.Foreground = new SolidColorBrush(Color.Parse("#7F1D1D"));
                
                MessageBorder.IsVisible = true;
                return;
            }

            // Hide the inline error border if it was previously shown
            MessageBorder.IsVisible = false;

            // Generate the personalized message
            string message = $"Welcome aboard, {name}!\n\nWe are pleased to officially welcome you to the {department} department for your {semester}. Please review your student portal for your upcoming schedule and academic resources. We wish you a highly successful term.";

            // Show the new Modal Window
            var dialog = new WelcomeDialog(message);
            await dialog.ShowDialog(this);
        }
    }
}
