
namespace MAUISampleDemo.View;

public partial class MAUIStyleDemo : ContentPage
{
	int count = 0;
	public MAUIStyleDemo()
	{
		InitializeComponent();
	}

    private void BtnClick_Clicked(object sender, EventArgs e)
    {
		count++;
		//if (count == 1)
  //          btnCounter.Text = $"Clicked {count} time";
		//else
  //          btnCounter.Text = $"Clicked {count} times";

		btnCounter.Text = (count == 1) ? $"Clicked {count} time" : $"Clicked {count} times";
        Resources["myColor"] = (count % 2 == 0) ? Colors.Red : Colors.Fuchsia;
    }
}