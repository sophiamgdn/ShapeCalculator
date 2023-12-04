namespace ShapeCalculator.Pages;

public partial class TriangleCalculator : ContentPage
{
    public TriangleCalculator()
    {
        InitializeComponent();
        Shell.Current.Title = "Triangle";
        pkrArea.SelectedIndex = 0;
        pkrPerimeter.SelectedIndex = 0;
        pkrVolume.SelectedIndex = 0;
    }

    private void OnbtnCalculateArea_Clicked(object sender, EventArgs e)
    {
        float area = 0;
        if (txtBase.Text == null || txtHeight.Text == null)
        {
            area = 0;
            txtResultArea.Text = area.ToString();

        }
        else
        {
            area = float.Parse(txtBase.Text) * float.Parse(txtHeight.Text) / 2;
            txtResultArea.Text = string.Concat(area.ToString(), pkrArea.SelectedItem as String);
        }
        
    }

    private void OnbtnCancelArea_Clicked(object sender, EventArgs e)
    {
        txtBase.Text = null;
        txtHeight.Text = null;
        pkrArea.SelectedIndex = 0;
        txtResultArea.Text= null;
    }

    private void OnbtnCalculatePerimeter_Clicked(object sender, EventArgs e)
    {
        float perimeter = 0;
        if(txtSide1.Text == null  || txtSide2.Text == null || txtSide3.Text == null)
        {
            perimeter = 0;
            txtResultPerimeter.Text = perimeter.ToString();
        }
        else
        {
            perimeter = float.Parse(txtSide1.Text) + float.Parse(txtSide2.Text) + float.Parse(txtSide3.Text);
            txtResultPerimeter.Text = string.Concat(perimeter.ToString(), pkrPerimeter.SelectedItem as String);
        }
    }

    private void OnbtnCancelPerimeter_Clicked(object sender, EventArgs e)
    {
        txtSide1.Text= null;
        txtSide2.Text= null;
        txtSide3.Text= null;
        pkrPerimeter.SelectedIndex = 0;
        txtResultPerimeter.Text = null;
    }

    private void OnbtnCalculateVolume_Clicked(object sender, EventArgs e)
    {
        float volume = 0;  
        if(txtBaseRadius.Text == null || txtHeightVolume.Text == null)
        {
            volume = 0;
            txtResultVolume.Text = volume.ToString();
        }
        else
        {
            volume = (float)(float.Pi * Math.Pow(float.Parse(txtBaseRadius.Text), 2) * (float.Parse(txtHeightVolume.Text) / 3));
            txtResultVolume.Text = string.Concat(volume.ToString(), pkrVolume.SelectedItem as String);
        }
    }

    private void OnbtnCancelVolume_Clicked(object sender, EventArgs e)
    {
        txtBaseRadius.Text= null;
        txtHeightVolume.Text= null;
        pkrVolume.SelectedIndex = 0;
        txtResultVolume.Text = null;
    }
}