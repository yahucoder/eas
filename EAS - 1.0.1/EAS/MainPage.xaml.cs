using System;
using System.Diagnostics;
using Xamarin.Forms;
using System.Data;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;
using System.Collections.Specialized;
using System.Text;
using Android.App;
using System.Net.Http;
using System.Collections.ObjectModel;

using static Android.Content.ClipData;


namespace EAS
{
   
    public partial class MainPage : ContentPage 
    {
        string vError;
        public MainPage()
        {
            InitializeComponent();
        }

        

        private async void TraumaTeam_Clicked(object sender, EventArgs e) //Trauma Team Button
        {
            try
            {
                WebClient client = new WebClient();
                Uri uri = new Uri("domain.com/phpscript");
                NameValueCollection parameters = new NameValueCollection();
                parameters.Add("GGroup", "Trauma");
                client.UploadValuesCompleted += Client_UploadValuesCompleted;
                client.UploadValuesAsync(uri, parameters);
            }
            catch (Exception ex)
            {
                vError = ex.Message;
                await DisplayAlert("ERROR", vError, "OK");
            }
        }

        private void Client_UploadValuesCompleted(object sender, UploadValuesCompletedEventArgs e) //Display response from the database
        {
            try
            {
                string resStatus = Encoding.UTF8.GetString(e.Result);
                DisplayAlert("SUCCESS", resStatus, "OK");
            }
            catch (Exception ex)
            {
                vError = ex.Message;
                DisplayAlert("ERROR", vError, "OK");
            }
        }

        

        private async void PaedTrauma_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                Uri uri = new Uri("domain.com/phpscript");
                NameValueCollection parameters = new NameValueCollection();
                parameters.Add("GGroup", "Paediatrics-Trauma");
                client.UploadValuesCompleted += Client_UploadValuesCompleted;
                client.UploadValuesAsync(uri, parameters);
            }
            catch (Exception ex)
            {
                vError = ex.Message;
                await DisplayAlert("ERROR", vError, "OK");
            }
        }

        private async void AnesthesiaTeam_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                Uri uri = new Uri("domain.com/phpscript");
                NameValueCollection parameters = new NameValueCollection();
                parameters.Add("GGroup", "Anesthetic");
                client.UploadValuesCompleted += Client_UploadValuesCompleted;
                client.UploadValuesAsync(uri, parameters);
            }
            catch (Exception ex)
            {
                vError = ex.Message;
                await DisplayAlert("ERROR", vError, "OK");
            }
        }

        private async void PaedAnesthetic_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                Uri uri = new Uri("domain.com/phpscript");
                NameValueCollection parameters = new NameValueCollection();
                parameters.Add("GGroup", "Paediatrics-Anesthetic");
                client.UploadValuesCompleted += Client_UploadValuesCompleted;
                client.UploadValuesAsync(uri, parameters);
            }
            catch (Exception ex)
            {
                vError = ex.Message;
                await DisplayAlert("ERROR", vError, "OK");
            }
        }

        private async void SupportTeam_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                Uri uri = new Uri("domain.com/phpscript");
                NameValueCollection parameters = new NameValueCollection();
                parameters.Add("GGroup", "Supports");
                client.UploadValuesCompleted += Client_UploadValuesCompleted;
                client.UploadValuesAsync(uri, parameters);
            }
            catch (Exception ex)
            {
                vError = ex.Message;
                await DisplayAlert("ERROR", vError, "OK");
            }
        }

        private async void SecTeam_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                Uri uri = new Uri("domain.com/phpscript");
                NameValueCollection parameters = new NameValueCollection();
                parameters.Add("GGroup", "Security");
                client.UploadValuesCompleted += Client_UploadValuesCompleted;
                client.UploadValuesAsync(uri, parameters);
            }
            catch (Exception ex)
            {
                vError = ex.Message;
                await DisplayAlert("ERROR", vError, "OK");
            }
        }

    }
    
}
