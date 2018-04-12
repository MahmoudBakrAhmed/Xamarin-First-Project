using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Content;
using Android.Views;
using Android.Widget;
using Dubie;
using Dubie.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(HomeButton), typeof(LeftButtonRenderer))]

namespace Dubie.Droid
{
#pragma warning disable CS0618 // Type or member is obsolete
    public class LeftButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Background = ContextCompat.GetDrawable(Forms.Context, Resource.Drawable.leftbutton);
            }

        }
    }
#pragma warning restore CS0618 // Type or member is obsolete
}