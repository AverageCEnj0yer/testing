using Microsoft.Maui.Controls;
using System;

namespace testing.View
{
    public partial class CustomNavBarView : ContentView
    {
        public CustomNavBarView()
        {
            InitializeComponent();
        }

        // Example Click Handlers - Implement navigation here
        private async void OnLeftButton1Clicked(object sender, EventArgs e)
        {
            // Navigate to the Notes page
            await Shell.Current.GoToAsync("///NotesPage");
        }

        private async void OnLeftButton2Clicked(object sender, EventArgs e)
        {
            // Navigate to the Flashcards page
            await Shell.Current.GoToAsync("///FlashcardsPage");
        }

        private async void OnCenterButtonClicked(object sender, EventArgs e)
        {
            // Navigate to the Home page (which is the center button)
            // The CommandParameter "HomePage" can be used here if needed
            await Shell.Current.GoToAsync("///HomePage");
        }

        private async void OnRightButton1Clicked(object sender, EventArgs e)
        {
            // Navigate to the Forum page
            await Shell.Current.GoToAsync("///ForumPage");
        }

        private async void OnRightButton2Clicked(object sender, EventArgs e)
        {
        //Example: Navigate to a Profile page(replace with your actual page / route)
             await Shell.Current.GoToAsync("///StudyPlan");
            //Or handle this button as needed (e.g., a different action)
        }

        // You might want to add logic here to visually indicate the currently active page
        // This could involve changing the color of the active button/icon.
    }
}