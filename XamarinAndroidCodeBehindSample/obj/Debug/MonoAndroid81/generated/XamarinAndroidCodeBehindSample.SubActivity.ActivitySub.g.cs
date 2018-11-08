using global::System;
using global::Android.App;
using global::Android.Widget;
using global::Android.Views;
using global::Android.OS;
using global::System.Reflection;

namespace XamarinAndroidCodeBehindSample
{
	partial class SubActivity
	{
		Binding.ActivitySub __layout_binding;

		public override void SetContentView (global::Android.Views.View view)
		{
			__layout_binding = new global::Binding.ActivitySub (view);
			bool callBase = true;
			OnSetContentView (view, ref callBase);
			if (callBase) {
				base.SetContentView (view);
			}
		}

		void SetContentView (global::Android.Views.View view, global::Xamarin.Android.Design.OnLayoutItemNotFoundHandler onLayoutItemNotFound)
		{
			__layout_binding = new global::Binding.ActivitySub (view, onLayoutItemNotFound);
			bool callBase = true;
			OnSetContentView (view, ref callBase);
			if (callBase) {
				base.SetContentView (view);
			}
		}

		public override void SetContentView (global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams @params)
		{
			__layout_binding = new global::Binding.ActivitySub (view);
			bool callBase = true;
			OnSetContentView (view, @params, ref callBase);
			if (callBase) {
				base.SetContentView (view, @params);
			}
		}

		void SetContentView (global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams @params, global::Xamarin.Android.Design.OnLayoutItemNotFoundHandler onLayoutItemNotFound)
		{
			__layout_binding = new global::Binding.ActivitySub (view, onLayoutItemNotFound);
			bool callBase = true;
			OnSetContentView (view, @params, ref callBase);
			if (callBase) {
				base.SetContentView (view, @params);
			}
		}

		public override void SetContentView (int layoutResID)
		{
			__layout_binding = new global::Binding.ActivitySub (this);
			bool callBase = true;
			OnSetContentView (layoutResID, ref callBase);
			if (callBase) {
				base.SetContentView (layoutResID);
			}
		}

		void SetContentView (int layoutResID, global::Xamarin.Android.Design.OnLayoutItemNotFoundHandler onLayoutItemNotFound)
		{
			__layout_binding = new global::Binding.ActivitySub (this, onLayoutItemNotFound);
			bool callBase = true;
			OnSetContentView (layoutResID, ref callBase);
			if (callBase) {
				base.SetContentView (layoutResID);
			}
		}

		partial void OnSetContentView (global::Android.Views.View view, ref bool callBaseAfterReturn);
		partial void OnSetContentView (global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams @params, ref bool callBaseAfterReturn);
		partial void OnSetContentView (int layoutResID, ref bool callBaseAfterReturn);

		public TextView Message => __layout_binding?.Message;
	}
}
