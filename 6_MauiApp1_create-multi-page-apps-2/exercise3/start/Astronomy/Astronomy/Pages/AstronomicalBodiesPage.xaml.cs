namespace Astronomy.Pages;

public partial class AstronomicalBodiesPage : ContentPage
{
	public AstronomicalBodiesPage()
	{
		InitializeComponent();

    }
    public AstronomicalBodiesPage()
    {
        InitializeComponent();

        btnComet.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=comet");
        btnEarth.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=earth");
        btnMoon.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=moon");
        btnSun.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=sun");
    }
    string astroName;
    public string AstroName
    {
        get => astroName;
        set
        {
            astroName = value;

            // this is a custom function to update the UI immediately
            UpdateAstroBodyUI(astroName);
        }
    }
    [QueryProperty(nameof(AstroName), "astroName")]
    public partial class AstronomicalBodyPage
    { 
    
    }
}