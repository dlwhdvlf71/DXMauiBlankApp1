namespace DXMauiBlankApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool OnLeave { get; set; }
    }
}