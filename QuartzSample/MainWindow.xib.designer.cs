// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace QuartzSample {
	
	
	// Base type probably should be MonoTouch.Foundation.NSObject or subclass
	[Foundation.Register("AppDelegate")]
	public partial class AppDelegate {
		
		private UIKit.UIWindow __mt_window;
		
		private UIKit.UINavigationController __mt_navigationController;
		
		#pragma warning disable 0169
		[Foundation.Connect("window")]
		private UIKit.UIWindow window {
			get {
				this.__mt_window = ((UIKit.UIWindow)(this.GetNativeField("window")));
				return this.__mt_window;
			}
			set {
				this.__mt_window = value;
				this.SetNativeField("window", value);
			}
		}
		
		[Foundation.Connect("navigationController")]
		private UIKit.UINavigationController navigationController {
			get {
				this.__mt_navigationController = ((UIKit.UINavigationController)(this.GetNativeField("navigationController")));
				return this.__mt_navigationController;
			}
			set {
				this.__mt_navigationController = value;
				this.SetNativeField("navigationController", value);
			}
		}
	}
	
	// Base type probably should be MonoTouch.UIKit.UITableViewController or subclass
	[Foundation.Register("MainViewController")]
	public partial class MainViewController {
	}
}
