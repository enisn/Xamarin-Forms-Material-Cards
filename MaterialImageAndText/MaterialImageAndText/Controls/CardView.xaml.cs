using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaterialImageAndText.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardView : Frame
    {
        public CardView()
        {
            InitializeComponent();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            boxCardColor.HeightRequest = boxCardColor.Width / 16 * 9;
            imgCard.HeightRequest = imgCard.Width / 16 * 9;

        }
        
        private void Card_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.CardDetail());
        }
    }
}