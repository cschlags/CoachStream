using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShellLogin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellLogin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public List<Athlete> AllAthletes { get; set; }
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            AllAthletes = new List<Athlete>(Athletes.Get());
            collectionViewAthletes.ItemsSource = AllAthletes;
        }
    }
}