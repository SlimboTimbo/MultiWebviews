using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using MultiWebviews.ViewModels;

using System.Collections.ObjectModel;

namespace MultiWebviews
{

    public partial class MainPage : ContentPage
    {

        public ObservableCollection<PageViewModel> pages { get; set; }

        public MainPage()
        {

           
            InitializeComponent();

            pages = new ObservableCollection<PageViewModel>();
                pages.Add(new PageViewModel{ Name="Test 1" });
                pages.Add(new PageViewModel{ Name= "Test 2 Test 2 Test 2 Test 2 Test 2 Test 2 Test 2 Test 2 Test 2 Test 2 Test 2 Test 2 Test 2 Test 2 Test 2 Test 2 " });
                pages.Add(new PageViewModel{ Name="Test 3" });
            lstView.ItemsSource = pages;


            // this.BindingContext = new[] { "Marc Williams", "Ridder Rivera", "Jose Ganatti" };
        }
    }
}
