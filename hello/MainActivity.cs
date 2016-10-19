using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace hello
{
    [Activity(Label = "hello", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        private Button button;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            button = FindViewById<Button>(Resource.Id.MyButton);

            // button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
            button.Click += Button_Click;

            var button1 = FindViewById<Button>(Resource.Id.button1);
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Czesc Karolinko", ToastLength.Long).Show();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            button.Text = string.Format("{0} clicks!", count++);
            Toast.MakeText(this, "Siema", ToastLength.Short).Show();
        }
    }
}

