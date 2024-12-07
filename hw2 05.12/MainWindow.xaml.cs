using System.Windows;
using System.Windows.Controls;

namespace hw2_05._12
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            change_btn_size();
        }
        
        private void num_click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn && btn.Content is string digit)
            {
                InputTextBox.Text += digit;
            }
        }
        
        private void clear_click(object sender, RoutedEventArgs e)
        {
            InputTextBox.Clear();
        }
        
        private void enter_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Your input: {InputTextBox.Text}", "Input code");
        }
        
        private void window_size(object sender, SizeChangedEventArgs e)
        {
            change_btn_size();
        }
        
        private void change_btn_size()
        {
            double size = 100; 
            
            double panel_height = NumericPanel.ActualHeight;
            double panel_width = NumericPanel.ActualWidth;

            if (panel_height > 0 && panel_width > 0)
            {
                size = Math.Min(panel_height / 4, panel_width / 3) - 10; 
            }
            
            foreach (UIElement element in NumericPanel.Children)
            {
                if (element is Button btn)
                {
                    btn.Width = size;
                    btn.Height = size;
                }
            }
        }
    }
}
