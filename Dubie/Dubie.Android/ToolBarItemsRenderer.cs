using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Dubie.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ContentPage), typeof(ToolBarItemsRenderer))]


namespace Dubie.Droid
{
#pragma warning disable CS0618 // Type or member is obsolete
    class ToolBarItemsRenderer : PageRenderer
    {
        protected override void OnLayout(bool changed, int l, int t, int r, int b) {
            base.OnLayout(changed, l, t, r, b);
            var actionBar = ((Activity)Context).ActionBar;
            if(actionBar != null)
                actionBar.SetBackgroundDrawable(Resources.GetDrawable(Resource.Drawable.BarBackground));
        }
    }
}