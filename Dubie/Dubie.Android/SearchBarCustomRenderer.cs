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
using Dubie.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Xamarin.Forms.SearchBar), typeof(SearchBarCustomRenderer))]

namespace Dubie.Droid
{
#pragma warning disable CS0618 // Type or member is obsolete
    public class SearchBarCustomRenderer : SearchBarRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = ContextCompat.GetDrawable(Forms.Context, Resource.Drawable.searchbar);
            }
        }
    }
#pragma warning restore CS0618 // Type or member is obsolete
}