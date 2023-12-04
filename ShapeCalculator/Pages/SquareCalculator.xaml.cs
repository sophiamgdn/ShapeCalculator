namespace ShapeCalculator.Pages;

public partial class SquareCalculator : ContentPage
{
	public SquareCalculator()
	{
		InitializeComponent();
        Shell.Current.Title = "Square";
		pkrArea.SelectedIndex = 0;
    }

    private void OnbtnCalculate_Clicked(object sender, EventArgs e)
    {
        float area, perimeter, volume = 0;
        if(txtSide.Text == null)
        {
            txtResultArea.Text = "0";
            txtResultPerimeter.Text = "0";
            txtResultVolume.Text = "0";
        }
        else
        {
            area = float.Parse(txtSide.Text) * float.Parse(txtSide.Text);
            perimeter = 4 * float.Parse(txtSide.Text);
            volume = float.Parse(txtSide.Text) * float.Parse(txtSide.Text) * float.Parse(txtSide.Text);

            txtResultArea.Text = String.Concat(area.ToString(), pkrArea.SelectedItem as String);
            txtResultPerimeter.Text = String.Concat(perimeter.ToString(), pkrArea.SelectedItem as String);
            txtResultVolume.Text = String.Concat(volume.ToString(), pkrArea.SelectedItem as String);
        }
    }

    private void OnbtnCancel_Clicked(object sender, EventArgs e)
    {
        txtSide.Text = null;
        txtResultArea.Text = null;
        txtResultPerimeter.Text= null;
        txtResultVolume.Text = null;
        pkrArea.SelectedIndex= 0;

    }
}