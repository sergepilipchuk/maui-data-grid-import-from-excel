using Android.App;
using Android.Runtime;

namespace maui_data_grid_import_from_excel;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}
		
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}