
using SignaturePad.Forms;
using System.IO;
using Xamarin.Forms;

namespace Drawing
{
   
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();

        }

       

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            signatureView.Clear();
            writeText.Source = "";
        }

        private async void Button_Clicked_1(object sender, System.EventArgs e)
        {
            Stream bitmap = await signatureView.GetImageStreamAsync(SignatureImageFormat.Png);
            writeText.Source = ImageSource.FromStream(() => { return bitmap; });
         
        }
    }
}
