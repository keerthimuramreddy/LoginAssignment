using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginAssignment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {

            string username = "admin";
            string password = "admin";

            
            string enteredUsername = usernameEntry.Text;
            string enteredPassword = passwordEntry.Text;

          
            if (enteredUsername == username && enteredPassword == password)
            {
                await DisplayAlert("Success", "Login successful!", "OK");
            }
            else
            {
                await DisplayAlert("Error", "Login failed. Please try again.", "OK");
            }
        }
    }
}