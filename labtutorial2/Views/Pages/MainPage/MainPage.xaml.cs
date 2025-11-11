using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace labtutorial2;

public partial class MainPage : ContentPage
{
    // Add this variable to track the "like" state
    private bool isLiked = false;

    public MainPage()
    {
        InitializeComponent();
    }

    // Add this new method for the Adoption button
    private async void OnAdoptionButtonClicked(object sender, EventArgs e)
    {
        // This will navigate to the new page you created
        await Navigation.PushAsync(new AdoptionPage());
    }

    // Add this new method for the Like button
    private void OnLikeButtonClicked(object sender, EventArgs e)
    {
        isLiked = !isLiked; // Toggle the like state

        if (isLiked)
        {
            // --- Liked State ---
            LikeButton.Text = "❤️"; // Use a heart emoji
            LikeButton.TextColor = Colors.Red;
            LikeButton.BorderColor = Colors.Red;
        }
        else
        {
            // --- Default State ---
            LikeButton.Text = "♡"; // Use the empty heart
            LikeButton.TextColor = Colors.Gray;
            LikeButton.BorderColor = Colors.LightGray;
        }
    }
}