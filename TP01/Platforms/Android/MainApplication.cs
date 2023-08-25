using Android.App;
using Android.Runtime;

namespace TP01;

//Marcelo Modesto de Lima Junior            CB3015823
//Bruna Helena Silva Santos                 CB3016111

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
