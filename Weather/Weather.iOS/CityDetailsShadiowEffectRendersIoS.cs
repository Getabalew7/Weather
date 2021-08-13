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
[assembly: ExportRenderer(typeof(CityDetailsShadowEffect), typeof(CityDetailsShadiowEffectRendersIoS))]
namespace Weather.iOS
{
    public class CityDetailsShadiowEffectRendersIoS : LabelRenderer
    {
        CityDetailsShadowEffect shadowEffect;
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                shadowEffect = (CityDetailsShadowEffect)e.NewElement;
                Layer.CornerRadius = 5;
                Layer.ShadowColor = Color.Red.ToCGColor();
                Layer.ShadowOpacity = (float)4.5;
                Layer.ShadowRadius = (float) shadowEffect.LabelShadow;
            }
        }
    }
}