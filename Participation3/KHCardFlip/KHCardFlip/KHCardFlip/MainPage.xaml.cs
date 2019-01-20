using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KHCardFlip
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When clicked, the 'Show Card Face' button will display the face of the card (ImgFace)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BtnFlip_Clicked(object sender, EventArgs e)
        {
            
            Button selectedButton = (Button)sender;
            
            //Logic to determine what happens depending on what text is shown on the button and which side of the card is shown when the button is pressed.
            if (selectedButton.Text == "Show Card Face")
            {
                //Show the card face
                ImgFace.IsVisible = true;
                //Hide the card back
                ImgBack.IsVisible = false;
                //Change the button text to show the card back
                BtnFlip.Text = "Show Card Back";  
            }
            else
            {
                //Show the card back
                ImgBack.IsVisible = true;
                //Hide the card face
                ImgFace.IsVisible = false;
                //Change the button text to show the card face
                BtnFlip.Text = "Show Card Face";
            }
        }
    }
}
