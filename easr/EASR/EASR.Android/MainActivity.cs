using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Plugin.LocalNotification;
using Android.Content;
using StructureMap.Pipeline;
using Matcha.BackgroundService.Droid;
using Xamarin.Forms;
using Stripe.Terminal;
using Android.Views;

namespace Easr.Droid
{
    
    [Activity(Label = "Easr", Icon = "@mipmap/easr", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle intent)
        {
            base.Window.RequestFeature(WindowFeatures.ActionBar);
            // Name of the MainActivity theme you had there before.
            // Or you can use global::Android.Resource.Style.ThemeHoloLight
            base.SetTheme(Resource.Style.MainTheme);
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(intent);
            Rg.Plugins.Popup.Popup.Init(this);
            Xamarin.Essentials.Platform.Init(this, intent);
            global::Xamarin.Forms.Forms.Init(this, intent);


            NotificationCenter.CreateNotificationChannel(new Plugin.LocalNotification.Platform.Droid.NotificationChannelRequest
            {
                EnableVibration = true,
                ShowBadge = true,
                LockScreenVisibility = NotificationVisibility.Public,
                EnableLights = true,
                Importance = NotificationImportance.Max,
                
            });
            LoadApplication(new App());
            NotificationCenter.NotifyNotificationTapped(Intent);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        protected override void OnNewIntent(Intent intent)
        {
            NotificationCenter.NotifyNotificationTapped(intent);
            base.OnNewIntent(intent);
        }

    }

}