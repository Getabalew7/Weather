using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Weather
{
    public class ThermometerView :Label
    {
        public static readonly BindableProperty TempratureProperty = BindableProperty.Create(
           propertyName: nameof(TempratureColor),
           returnType: typeof(Color),
           declaringType: typeof(ThermometerView),
           defaultValue: Color.AliceBlue
            );


        public Color TempratureColor
        {
            get { return (Color)GetValue(TempratureProperty); }
            set { SetValue(TempratureProperty, value); }
        }
        public static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create(
          "CornerRadius",
          returnType: typeof(int),
          declaringType: typeof(ThermometerView),
          defaultValue: default(int)
           );


        public int CornerRadius
        {
            get { return (int)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }
        public static readonly BindableProperty CityDetailTextShadowProperty = BindableProperty.Create(
        propertyName: nameof(LabelShadow),
         returnType: typeof(int),
         declaringType: typeof(ThermometerView),
         defaultValue: default(int)
          );


        public int LabelShadow
        {
            get { return (int)GetValue(CityDetailTextShadowProperty); }
            set { SetValue(CityDetailTextShadowProperty, value); }
        }

    }
}
