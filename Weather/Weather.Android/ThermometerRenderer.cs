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


[assembly: ExportRenderer(typeof(ThermometerView), typeof(ThermometerRenderer))]
namespace Weather.Droid
{
   
    public class ThermometerRenderer : LabelRenderer
    {
       public ThermometerRenderer(Context context): base(context)
        {

        }
        ThermometerView tview;

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if(e.OldElement == null)
            {
                tview = (ThermometerView)e.NewElement;
                var gradientDrawable = new GradientDrawable();

                gradientDrawable.SetCornerRadius(tview.CornerRadius);
                Control.SetBackground(gradientDrawable);
           
            }
        }
    }
}