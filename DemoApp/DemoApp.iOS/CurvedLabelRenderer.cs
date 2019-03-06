using System;
using DemoApp;
using DemoApp.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(CustomLabel), typeof(CurvedLabelRenderer))]
namespace DemoApp.iOS
{
    public class CurvedLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                var _xfViewReference = (CustomLabel)Element;
                this.Layer.CornerRadius = (float)_xfViewReference.CurvedCornerRadius;
                this.Layer.BackgroundColor = _xfViewReference.CurvedBackgroundColor.ToCGColor();
            }
        }
    }
}
