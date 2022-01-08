using System;
using ObjCRuntime;
using UIKit;

namespace Microsoft.Maui.Controls.Compatibility.Platform.iOS
{

	public interface IShellNavBarAppearanceTracker : IDisposable
	{
		void ResetAppearance(UINavigationController controller);
		void SetAppearance(UINavigationController controller, ShellAppearance appearance);
		void UpdateLayout(UINavigationController controller);
		void SetHasShadow(UINavigationController controller, bool hasShadow);
	}
}