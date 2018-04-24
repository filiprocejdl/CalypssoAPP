using System;
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
