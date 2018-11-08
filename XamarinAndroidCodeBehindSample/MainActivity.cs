using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using System;

namespace XamarinAndroidCodeBehindSample
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        public MainActivity() { }

        public MainActivity(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ActivityMain);

            var binding = new Binding.ActivityMain(this);

            SetSupportActionBar(binding.Toolbar);

            binding.FloatingActionButton.Click += fabClicked;
        }

        private void fabClicked(object sender, EventArgs eventArgs)
        {
            StartActivity(new Intent(this, typeof(SubActivity)));
        }
    }
}

