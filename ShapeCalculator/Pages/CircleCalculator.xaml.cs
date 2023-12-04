namespace ShapeCalculator.Pages;

public partial class CircleCalculator : ContentPage
{
	public CircleCalculator()
	{
		InitializeComponent();
        Shell.Current.Title = "Circle";
        pkrMeasurement.SelectedIndex = 0;
    }

    private void OnbtnCalculate_Clicked(object sender, EventArgs e)
    {
        if(txtRadius.Text == null)
        {
            txtArea.Text = "0";
            txtPerimeter.Text = "0";
            txtVolumeSphere.Text = "0";
        }
        else
        {
            float area = (float)(Math.PI * Math.Pow(float.Parse(txtRadius.Text), 2));
            float perimeter = (float)(2 * Math.PI * float.Parse(txtRadius.Text));
            float volSphere = (float)((4.0 / 3.0) * (Math.PI * Math.Pow(float.Parse(txtRadius.Text), 3)));
            txtArea.Text = string.Concat(area.ToString(), pkrMeasurement.SelectedItem as string);
            txtPerimeter.Text = string.Concat(perimeter.ToString(), pkrMeasurement.SelectedItem as string);
            txtVolumeSphere.Text = string.Concat(volSphere.ToString(), pkrMeasurement.SelectedItem as string);
        }
        
        
    }

    private void OnbtnClear_Clicked(object sender, EventArgs e)
    {
        txtRadius.Text = null;
        txtArea.Text = null;
        txtPerimeter.Text= null;
        txtVolumeSphere.Text = null;
        pkrMeasurement.SelectedIndex = 0; 
    }
}