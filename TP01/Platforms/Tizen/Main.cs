using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace TP01;

//Marcelo Modesto de Lima Junior            CB3015823
//Bruna Helena Silva Santos                 CB3016111

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
