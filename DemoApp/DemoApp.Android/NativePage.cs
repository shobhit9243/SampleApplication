using System;
using Android.Content;
using DemoApp.Droid;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(NativePage))]
namespace DemoApp.Droid
{

    public class NativePage : INativePages
    {
        public NativePage()
        {
        }
               
        public void StartActivityInAndroid()
        {
            var intent = new Intent(Forms.Context, typeof(MyActivity));
            Forms.Context.StartActivity(intent);
        }
    }
}
