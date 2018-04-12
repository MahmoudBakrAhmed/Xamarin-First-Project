using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Dubie.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Xamarin.Forms.ScrollView), typeof(ScrollRenderer))]

namespace Dubie.Droid
{
    class ScrollRenderer : ScrollViewRenderer
    {
#pragma warning disable CS0618 // Type or member is obsolete
        public ScrollRenderer()
        {
        }
#pragma warning restore CS0618 // Type or member is obsolete

        public ScrollRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            global::Android.Widget.ScrollView droidScrollView = (global::Android.Widget.ScrollView)this;
            droidScrollView.ScrollBarStyle = ScrollbarStyles.OutsideInset;
            droidScrollView.VerticalScrollbarPosition = ScrollbarPosition.Left;
        }
    }
}