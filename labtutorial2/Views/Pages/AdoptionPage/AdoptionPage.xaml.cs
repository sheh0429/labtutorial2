using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace labtutorial2;

public partial class AdoptionPage : ContentPage
{
    public AdoptionPage()
    {
        InitializeComponent();
    }

    
    private async void OnPageLoaded(object sender, EventArgs e)
    {
        // 1. Fade the label in
        await ThankYouLabel.FadeTo(1, 500, Easing.CubicIn);

        // 2. Make it "pop"
        await ThankYouLabel.ScaleTo(1.2, 300, Easing.SpringOut);
        await ThankYouLabel.ScaleTo(1.0, 300, Easing.SpringIn);
    }
}