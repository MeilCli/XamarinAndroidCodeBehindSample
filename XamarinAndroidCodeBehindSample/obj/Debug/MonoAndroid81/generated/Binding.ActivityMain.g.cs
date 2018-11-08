using global::System;
using global::Android.App;
using global::Android.Widget;
using global::Android.Views;
using global::Android.OS;

namespace Binding
{
	sealed class ActivityMain : global::Xamarin.Android.Design.LayoutBinding
	{

		[global::Android.Runtime.PreserveAttribute (Conditional=true)]
		public ActivityMain (
			global::Android.App.Activity client,
			global::Xamarin.Android.Design.OnLayoutItemNotFoundHandler itemNotFoundHandler = null)
				: base (client, itemNotFoundHandler)
		{}

		[global::Android.Runtime.PreserveAttribute (Conditional=true)]
		public ActivityMain (
			global::Android.Views.View client,
			global::Xamarin.Android.Design.OnLayoutItemNotFoundHandler itemNotFoundHandler = null)
				: base (client, itemNotFoundHandler)
		{}


		#line 15 "Resources\layout\ActivityMain.axml"

		Android.Support.V7.Widget.Toolbar __Toolbar;

		#line default
		#line hidden

		#line 15 "Resources\layout\ActivityMain.axml"

		// Declared in: Resources\layout\ActivityMain.axml:(15:10)
		// Declared in: Resources\layout\ActivityMain.axml:(15:10)
		// Type fixed up from 'android.support.v7.widget.Toolbar' to 'Android.Support.V7.Widget.Toolbar'. Element defined in Resources\layout\ActivityMain.axml:(15:10)
		// Type fixed up from 'android.support.v7.widget.Toolbar' to 'Android.Support.V7.Widget.Toolbar'. Element defined in Resources\layout\ActivityMain.axml:(15:10)
		public Android.Support.V7.Widget.Toolbar Toolbar => FindView (global::XamarinAndroidCodeBehindSample.Resource.Id.Toolbar, ref __Toolbar);

		#line default
		#line hidden


		#line 24 "Resources\layout\ActivityMain.axml"

		Android.Support.Design.Widget.FloatingActionButton __FloatingActionButton;

		#line default
		#line hidden

		#line 24 "Resources\layout\ActivityMain.axml"

		// Declared in: Resources\layout\ActivityMain.axml:(24:6)
		// Declared in: Resources\layout\ActivityMain.axml:(24:6)
		// Type fixed up from 'android.support.design.widget.FloatingActionButton' to 'Android.Support.Design.Widget.FloatingActionButton'. Element defined in Resources\layout\ActivityMain.axml:(24:6)
		// Type fixed up from 'android.support.design.widget.FloatingActionButton' to 'Android.Support.Design.Widget.FloatingActionButton'. Element defined in Resources\layout\ActivityMain.axml:(24:6)
		public Android.Support.Design.Widget.FloatingActionButton FloatingActionButton => FindView (global::XamarinAndroidCodeBehindSample.Resource.Id.FloatingActionButton, ref __FloatingActionButton);

		#line default
		#line hidden

	}
}
