using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wk10Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<DummyData> dummyData = new List<DummyData>();
        public MainWindow()
        {
            InitializeComponent();
            SendList();
            demoDG.ItemsSource= dummyData;
        }

        public void SendList()
        {
            for (int i = 0; i < 100; i++)
            {
                var temp = new DummyData();
                temp.ID = i;
                temp.FirstName = $"firstName:{i}";
                temp.LastName = $"lastName:{i}";
                temp.SomethingCool = $"{i * 22}";
                dummyData.Add(temp);
            }
        }

        private void Hello_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void EnterDemo(object sender, MouseEventArgs e)
        {
            btnHello.Content = "HELLO!";
        }

        private void LeaveDemo(object sender, MouseEventArgs e)
        {
            btnHello.Content = "Oh you Left...";
        }
    }

    public class DummyData
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? SomethingCool {  get; set; }
    }
}