using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using System;

namespace XamarinAndroidCodeBehindSample
{
    [Activity]
    public partial class SubActivity : AppCompatActivity
    {
        public SubActivity() { }

        public SubActivity(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ActivitySub);

            Message.Text = "Hello World";
        }
    }
}