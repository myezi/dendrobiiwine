using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using DendrobiiWine.Mobile.Services;

namespace DendrobiiWine.Mobile.Views.Customer
{
    public class MapPage : ContentPage
    {
        public MapPage()
        {
            var map = new Map
            {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            var toolbarItem = new ToolbarItem();
            toolbarItem.Text = "打开导航";
            toolbarItem.Clicked += delegate {
                var result = DependencyService.Get<IThirdPartyAppService>().Link("intent://map/marker?location=40.047669,116.313082&title=我的位置&content=百度奎科大厦&src=MendrobiiWine#Intent;scheme=bdapp;package=com.baidu.BaiduMap;end");
            };
            ToolbarItems.Add(toolbarItem);

            Content = new StackLayout
            {
                Children = {
                    map
                }
            };
        }
    }
}
