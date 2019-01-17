using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KHLangTrans
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Display Italian Translation for Good Morning
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BtnItalian_Clicked(object sender, EventArgs e)
        {
            //Change results to say Good Morning in Italian
            lblTranslation.Text = "Buongiorno"; 
        }


        /// <summary>
        /// Display the Spanish translation for Good Morning
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BtnSpanish_Clicked(object sender, EventArgs e)
        {
            //Change results to say Good Morning in Spanish
            lblTranslation.Text = "Buenos Dias";
        }


        /// <summary>
        /// Display the German translation for Good Morning
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
 
        private void BtnGerman_Clicked(object sender, EventArgs e)
        {
            //Change results to say Good Morning in German
            lblTranslation.Text = "Guten Morgen";
        }
    }
}
