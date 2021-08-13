using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Weather;
using Weather.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly:ExportRenderer(typeof(ThermometerView), typeof(ThermometerRendererIos))]
namespace Weather.iOS
{
    class ThermometerRendererIos: LabelRenderer
    {
        ThermometerView tview;
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                tview =(ThermometerView)e.NewElement;

                Layer.CornerRadius = tview.CornerRadius;
            }
        }
    }
}