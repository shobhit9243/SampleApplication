using System;
using CoreGraphics;
using DemoApp.iOS;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(NativeIOS))]
namespace DemoApp.iOS
{
   
    public class NativeIOS : INativePages
    {
        UIViewController vc;
        public NativeIOS()
        {
        }

        public void StartActivityInAndroid()
        {
            if (vc != null) throw new Exception("View already showing");
            vc = new UIViewController();
            var button = new UIButton(new CGRect(100, 100, 300, 300));
            button.SetTitle("Press to Exit", UIControlState.Normal);
            button.BackgroundColor = UIColor.Orange;
            button.TouchUpInside += (object sender, EventArgs e) =>
            {
                Dismiss();
            };
            vc.Add(button);
            var rootVC = UIApplication.SharedApplication.Windows[0].RootViewController;
            rootVC.PresentViewController(vc, true, () => { });
        }
        public void Dismiss()
        {
            vc?.DismissViewController(true, () =>
            {
                vc.Dispose();
                vc = null;
            });
        }
    }
}
