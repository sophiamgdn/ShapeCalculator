using ShapeCalculator.Pages;

namespace ShapeCalculator
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            Shell.Current.Title = "Shape Calculator";
        }

        private async void OnbtnTriangle_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TriangleCalculator());
        }

        private async void OnbtnSquare_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SquareCalculator());
        }

        private async void OnbtnRectangle_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RectangleCalculator());
        }

        private async void OnbtnCircle_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CircleCalculator());
        }


    }
}