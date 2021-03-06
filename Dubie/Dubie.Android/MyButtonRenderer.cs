﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Dubie;
using Dubie.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Button), typeof(MyButtonRenderer))]

namespace Dubie.Droid
{

#pragma warning disable CS0618 // Type or member is obsolete
    public class MyButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null) {
                Control.SetAllCaps(false);
                Control.SetLines(3);
                Control.SetLineSpacing(1.0f,0.7f);
                Control.TextAlignment = Android.Views.TextAlignment.Center;
            }

        }
    }
#pragma warning restore CS0618 // Type or member is obsolete
}