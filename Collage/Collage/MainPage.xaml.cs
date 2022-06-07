using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Collage
{
    public partial class MainPage : ContentPage
    {
        private int index = 0;
        private readonly String[] arrImg = { "https://www.fillmurray.com/500/500", "https://www.fillmurray.com/600/600", "https://www.fillmurray.com/800/800" };

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnRight_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Equals(btnLeft))
            {
                if (index > 0)
                {
                    index--;
                    image.Source = arrImg[index];
                }
            }
            else if (button.Equals(btnRight))
            {
                if (index < arrImg.Length - 1)
                {
                    index++;
                    image.Source = arrImg[index];
                }
            }
        }
    }
}
