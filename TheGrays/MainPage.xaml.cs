namespace TheGrays;

public partial class MainPage
{
	private bool _isPlaying;

	public MainPage()
	{
		InitializeComponent();
		mediaElement.MediaEnded += OnMediaEnded;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		if (_isPlaying)
		{
			Console.WriteLine("Tom Slick is still speaking");
			return;
		}
		_isPlaying = true;
		Console.WriteLine("Tom Slick is saying the F-Word");
		mediaElement.Play();
	}

	private void OnMediaEnded(object sender, EventArgs e)
	{
		mediaElement.Stop();
		mediaElement.SeekTo(TimeSpan.Zero);
		Console.WriteLine("Tom Slick finished saying the F-Word");
		_isPlaying = false;
	}

	protected override void OnDisappearing()
	{
		base.OnDisappearing();
		// Stop and cleanup MediaElement when we navigate away
		mediaElement.Handler?.DisconnectHandler();
	}
}


