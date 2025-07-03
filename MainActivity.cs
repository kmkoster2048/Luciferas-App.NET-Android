using Android.App;
using Android.OS;
using Android.Webkit;
using Android.Widget;

namespace Luciferas_App
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);

            // Find the WebView and load a website
            var webView = FindViewById<WebView>(Resource.Id.webView);
            if (webView != null)
            {
                webView.Settings.JavaScriptEnabled = true;
                webView.SetWebViewClient(new WebViewClient());
                webView.LoadUrl("https://lucifera.eu");
            }
        }

        public override void OnBackPressed()
        {
            var webView = FindViewById<WebView>(Resource.Id.webView);
            if (webView != null && webView.CanGoBack())
            {
                webView.GoBack();
            }
            else
            {
                base.OnBackPressed();
            }
        }
    }
}