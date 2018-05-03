using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace CalypssoAPP
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            new MyFrame();


        }

        public async Task GetItemAsync()
        {
            RestUrl = http://example.com/
            var uri = new Uri(string.Format(Constants.RestUrl, string.Empty));
            var response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject > (content);
            }
        }



        public class MyFrame : Xamarin.Forms.Frame
        {
            public static float myFrameWidth = 2;
            public static float myCornerRadius = 12;
            public static Color myFrameColor = Color.Red;
            public static Color myBackgroundColor = Color.Black;

            public MyFrame() { }
        }
    }
}
