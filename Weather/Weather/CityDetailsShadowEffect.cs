using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Weather
{
   public  class CityDetailsShadowEffect:Label
    {
        public static readonly BindableProperty ShadowedLabelProperty = BindableProperty.Create(
         propertyName: nameof(LabelShadow),
         returnType: typeof(int),
         declaringType: typeof(CityDetailsShadowEffect),
         defaultValue: default(int));
        public int LabelShadow
        {
            get { return (int)GetValue(ShadowedLabelProperty); }
            set { SetValue(ShadowedLabelProperty, value); }
        }
    }
}
