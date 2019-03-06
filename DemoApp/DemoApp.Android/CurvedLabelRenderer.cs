using System;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Util;
using DemoApp;
using DemoApp.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(CurvedLabelRenderer))]
namespace DemoApp.Droid
{
 public class CurvedLabelRenderer : LabelRenderer  
    {  
        private GradientDrawable _gradientBackground;
        public CurvedLabelRenderer(Context context) : base(context)
        {
            AutoPackage = false;
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)  
        {  
            base.OnElementChanged(e);  
            var view = (CustomLabel)Element;  
            if (view == null) return;  
            // creating gradient drawable for the curved background  
            _gradientBackground = new GradientDrawable();  
            _gradientBackground.SetShape(ShapeType.Rectangle);  
            _gradientBackground.SetColor(view.CurvedBackgroundColor.ToAndroid());  
  
            // Thickness of the stroke line  
            _gradientBackground.SetStroke(4, view.CurvedBackgroundColor.ToAndroid());  
  
            // Radius for the curves  
            _gradientBackground.SetCornerRadius(DpToPixels(this.Context,  
                Convert.ToSingle(view.CurvedCornerRadius)));  
  
            // set the background of the label  
            Control.SetBackground(_gradientBackground);  
        }  
        //Px to Dp Conver  
        public static float DpToPixels(Context context, float valueInDp)  
        {  
            DisplayMetrics metrics = context.Resources.DisplayMetrics;  
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp, metrics);  
        }  
    }  
}
