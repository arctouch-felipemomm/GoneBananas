using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using CocosSharp;
using GoneBananasiOS;

namespace GoneBananas
{
    [Register ("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        public override void FinishedLaunching (UIApplication app)
        {
            var application = new CCApplication ();
            application.ApplicationDelegate = new GoneBananasApplicationDelegate();
            ((GoneBananasApplicationDelegate)application.ApplicationDelegate).SetSettings(new SettingsImplementation());
            application.StartGame ();
        }
    }
}