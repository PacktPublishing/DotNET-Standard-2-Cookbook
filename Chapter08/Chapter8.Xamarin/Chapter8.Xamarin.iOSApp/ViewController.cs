using System;
using Chapter8.Xamarin.iOSLib;

using UIKit;

namespace Chapter8.Xamarin.iOSApp
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            HelloButton.TouchUpInside += (object sender, EventArgs e) =>
            {

                var greetings = new HelloLib();
                var message = greetings.SayHello("Fiqri Ismail");

                //Create an alert box
                var greetingsAlert = UIAlertController.Create("Hello", message, UIAlertControllerStyle.Alert);
                greetingsAlert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));


                PresentViewController(greetingsAlert, true, null);

            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
