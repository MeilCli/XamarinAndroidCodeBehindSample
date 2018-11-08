using global::System;
using global::Android.App;
using global::Android.Widget;
using global::Android.Views;
using global::Android.OS;

namespace Binding
{
	sealed class ActivitySub : global::Xamarin.Android.Design.LayoutBinding
	{

		[global::Android.Runtime.PreserveAttribute (Conditional=true)]
		public ActivitySub (
			global::Android.App.Activity client,
			global::Xamarin.Android.Design.OnLayoutItemNotFoundHandler itemNotFoundHandler = null)
				: base (client, itemNotFoundHandler)
		{}

		[global::Android.Runtime.PreserveAttribute (Conditional=true)]
		public ActivitySub (
			global::Android.Views.View client,
			global::Xamarin.Android.Design.OnLayoutItemNotFoundHandler itemNotFoundHandler = null)
				: base (client, itemNotFoundHandler)
		{}


		#line 10 "Resources\layout\ActivitySub.axml"

		TextView __Message;

		#line default
		#line hidden

		#line 10 "Resources\layout\ActivitySub.axml"

		// Declared in: Resources\layout\ActivitySub.axml:(10:3)
		// Declared in: Resources\layout\ActivitySub.axml:(10:3)
		public TextView Message => FindView (global::XamarinAndroidCodeBehindSample.Resource.Id.Message, ref __Message);

		#line default
		#line hidden

	}
}
