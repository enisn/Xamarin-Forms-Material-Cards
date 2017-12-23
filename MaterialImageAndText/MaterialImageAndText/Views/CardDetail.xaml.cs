using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaterialImageAndText.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardDetail : ContentPage
    {
        public CardDetail()
        {
            InitializeComponent();

        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            imgCard.HeightRequest = imgCard.Width * 2 / 3; // set the height of Image to 3:2 Ratio



            //This keeps all margin as same value which given from XAML. Only changes Top Margin as Image height
            grdContentArea.Margin = new Thickness(grdContentArea.Margin.Left, imgCard.Height, grdContentArea.Margin.Right, grdContentArea.Margin.Bottom);

            //Set the content height as scrollable
            grdContentArea.HeightRequest = grdContentArea.Height > this.Height ? grdContentArea.Height : this.Height;

            //boxCardColor.HeightRequest = boxCardColor.Width / 16 * 9;
        }

        private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            imgCard.TranslateTo(0, -1 * (e.ScrollY / 2), 2);
            if (e.ScrollY < imgCard.Height)
            {
                imgFloatButton.TranslateTo(0,e.ScrollY /5, 25);
            }
            else
            {
                imgFloatButton.TranslateTo(0, this.Height - imgFloatButton.Height, 100);
            }

        }
    }
}