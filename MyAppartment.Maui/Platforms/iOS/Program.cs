﻿using ObjCRuntime;
using UIKit;

namespace MyAppartment.Maui;
public class Program
{
    // This is the Main entry point of the application.
    static void Main(string[] args)
    {
        // if you want to use a different Application Delegate class from "AppDelegate"
        // you can specify it here.
        UIApplication.Main(args, null, typeof(AppDelegate));
    }
}
