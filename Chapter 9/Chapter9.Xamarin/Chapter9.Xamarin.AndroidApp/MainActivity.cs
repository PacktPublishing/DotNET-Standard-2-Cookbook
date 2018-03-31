using Android.App;
using Android.Widget;
using Android.OS;
using Chapter9.Xamarin.AndroidLib;

namespace Chapter9.Xamarin.AndroidApp
{
    [Activity(Label = "Chapter9.Xamarin.AndroidApp", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 0;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            CounterLib counter = new CounterLib();

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += delegate { 
                count = counter.IncrementByOne(count);
                button.Text = $"{count} clicks!";
            };
        }
    }
}

