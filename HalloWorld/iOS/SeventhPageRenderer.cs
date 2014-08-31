using System;
using System.Drawing;
using Xamarin.Forms.Platform.iOS;
using MonoTouch.UIKit;
using Xamarin.Forms;

[assembly:ExportRenderer(typeof(HalloWorld.SeventhPage),typeof(HalloWorld.iOS.SeventhPageRenderer))]

namespace HalloWorld.iOS
{
	public class SeventhPageRenderer : PageRenderer
	{
		protected override void OnElementChanged (VisualElementChangedEventArgs e)
		{
			base.OnElementChanged (e);

			var page = e.NewElement as SeventhPage;

			var hostViewController = ViewController;

			var viewController = new UIViewController ();

			var label = new UILabel (new RectangleF(0, 40, 320, 40));
			label.Text = "3 " + page.Heading;
			viewController.View.Add (label);

			hostViewController.AddChildViewController (viewController);
			hostViewController.View.Add (viewController.View);

			viewController.DidMoveToParentViewController (hostViewController);
		}
	}
}

