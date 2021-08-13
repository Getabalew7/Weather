using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weather;
using Weather.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(CityDetailsShadowEffect), typeof(CityDetailsShadowEffectDroid))]
namespace Weather.Droid
{
    class CityDetailsShadowEffectDroid : LabelRenderer
    {
        public CityDetailsShadowEffectDroid(Context context) : base(context)
        {

        }
        CityDetailsShadowEffect shadowEffect;

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                shadowEffect = (CityDetailsShadowEffect)e.NewElement;
                var gradientDrawable = new GradientDrawable();

                gradientDrawable.SetCornerRadius(shadowEffect.LabelShadow);
               // Control.ShadowRadius = tview.LabelShadow;
                Control.SetBackground(gradientDrawable);

            }
        }
    }
}