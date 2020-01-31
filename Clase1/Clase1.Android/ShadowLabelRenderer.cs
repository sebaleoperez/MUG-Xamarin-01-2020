using System;
using Android.Content;
using Clase1.Droid;
using Clase1.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ShadowLabel), typeof(ShadowLabelRenderer))]
namespace Clase1.Droid
{
    public class ShadowLabelRenderer : LabelRenderer
    {


        public ShadowLabelRenderer(Context context) : base(context) { }


        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e); Control.SetShadowLayer(10, 5, 5, Android.Graphics.Color.DarkGray);
        }

    }
}
