using DendrobiiWine.Mobile.App_Code;
using DendrobiiWine.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DendrobiiWine.Mobile.Pages.Customer
{
    public partial class CustomerMainPage : ContentPage
    {
        public CustomerMainPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<MerchantModel>
            {
                new MerchantModel {
                    Image = ImageSource.FromUri(new Uri("http://avatar.csdn.net/9/A/4/1_tangcheng_ok.jpg")),
                    Name = "马山牛奶",
                    Description = "[东亭]鲜牛奶30杯每天送 不限时间段通用",
                    Price = "80.00"
                },
                new MerchantModel {
                    Image = ImageSource.FromUri(new Uri("http://avatar.csdn.net/9/A/4/1_tangcheng_ok.jpg")),
                    Name = Guid.NewGuid().ToString(),
                    Description = DateTime.Now.ToString()
                },
                new MerchantModel {
                    Image = ImageSource.FromUri(new Uri("http://avatar.csdn.net/9/A/4/1_tangcheng_ok.jpg")),
                    Name = Guid.NewGuid().ToString(),
                    Description = DateTime.Now.ToString()
                },
                new MerchantModel {
                    Image = ImageSource.FromUri(new Uri("http://avatar.csdn.net/9/A/4/1_tangcheng_ok.jpg")),
                    Name = Guid.NewGuid().ToString(),
                    Description = DateTime.Now.ToString()
                },
                new MerchantModel {
                    Name = Guid.NewGuid().ToString(),
                    Description = DateTime.Now.ToString()
                },
                new MerchantModel {
                    Name = Guid.NewGuid().ToString(),
                    Description = DateTime.Now.ToString()
                },
                new MerchantModel {
                    Name = Guid.NewGuid().ToString(),
                    Description = DateTime.Now.ToString()
                },
                new MerchantModel {
                    Name = Guid.NewGuid().ToString(),
                    Description = DateTime.Now.ToString()
                },
                new MerchantModel {
                    Name = Guid.NewGuid().ToString(),
                    Description = DateTime.Now.ToString()
                },
                new MerchantModel {
                    Name = Guid.NewGuid().ToString(),
                    Description = DateTime.Now.ToString()
                },
                new MerchantModel {
                    Name = Guid.NewGuid().ToString(),
                    Description = DateTime.Now.ToString()
                },
                new MerchantModel {
                    Name = Guid.NewGuid().ToString(),
                    Description = DateTime.Now.ToString()
                },
                new MerchantModel {
                    Name = Guid.NewGuid().ToString(),
                    Description = DateTime.Now.ToString()
                },
                new MerchantModel {
                    Name = Guid.NewGuid().ToString(),
                    Description = DateTime.Now.ToString()
                },
                new MerchantModel {
                    Name = Guid.NewGuid().ToString(),
                    Description = DateTime.Now.ToString()
                },
                new MerchantModel {
                    Name = Guid.NewGuid().ToString(),
                    Description = DateTime.Now.ToString()
                },
                new MerchantModel {
                    Name = Guid.NewGuid().ToString(),
                    Description = DateTime.Now.ToString()
                },
            };
        }
        
        private async void OnCityClick(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CityListPage());
        }

        private async void OnBarCodeClick(object sender, EventArgs e) { }

        private async void OnSearchClick(object sender, EventArgs e) { }

        private async void OnProfileClick(object sender, EventArgs e) { }
    }
}
