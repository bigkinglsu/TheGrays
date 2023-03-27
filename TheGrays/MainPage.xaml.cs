namespace TheGrays;

public partial class MainPage : ContentPage
{
	public MainPage() => InitializeComponent();

	private void OnCounterClicked(object sender, EventArgs e)
	{
		Console.WriteLine("Tom Slick said the F-Word");
	}
}


