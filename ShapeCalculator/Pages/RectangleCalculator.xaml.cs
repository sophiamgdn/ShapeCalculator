namespace ShapeCalculator.Pages;

public partial class RectangleCalculator : ContentPage
{
	public RectangleCalculator()
	{
		InitializeComponent();
        Shell.Current.Title = "Rectangle";
        pkrArea.SelectedIndex = 0;
        pkrVolume.SelectedIndex = 0;
    }

    private void OnbtnCalculateArea_Clicked(object sender, EventArgs e)
    {
        float area = 0;
        float perimeter = 0;
        if(txtWidth.Text == null || txtLength.Text == null)
        {
            area = 0;
            perimeter = 0;
            txtResultArea.Text = area.ToString();
            txtResultPerimeter.Text = perimeter.ToString();
        }
        else
        {
            area = float.Parse(txtWidth.Text) * float.Parse(txtLength.Text);
            perimeter = 2 * (float.Parse(txtLength.Text) + float.Parse(txtWidth.Text));
            txtResultArea.Text = String.Concat(area.ToString(), pkrArea.SelectedItem as String);
            txtResultPerimeter.Text = String.Concat(perimeter.ToString(), pkrArea.SelectedItem as String);
        }
    }

    private void OnbtnCancelArea_Clicked(object sender, EventArgs e)
    {
        txtWidth.Text = null;
        txtLength.Text = null;
        txtResultArea.Text  = null;
        txtResultPerimeter.Text = null;
        pkrArea.SelectedIndex = 0;
    }

    private void OnbtnCalculateVolume_Clicked(object sender, EventArgs e)
    {
        float volume = 0;
        if(txtLengthVol.Text == null || txtWidthVol.Text == null || txtHeightVol.Text == null)
        {
            txtResultVolume.Text = "0";
        }
        else
        {
            volume = float.Parse(txtLengthVol.Text) * float.Parse(txtWidthVol.Text) * float.Parse(txtHeightVol.Text);
            txtResultVolume.Text = String.Concat(volume.ToString(), pkrVolume.SelectedItem as String);
        }
        
    }

    private void OnbtnCancelVolume_Clicked(object sender, EventArgs e)
    {
        txtLengthVol.Text = null;
        txtWidthVol.Text = null;
        txtHeightVol.Text = null;
        txtResultVolume.Text = null;    
        pkrVolume.SelectedIndex = 0;
    }
}