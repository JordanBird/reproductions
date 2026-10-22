using AndroidX.Activity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiModalAndroidBackReproduction.Platforms.Android.Reproduction
{
    public class OnBackPress : OnBackPressedCallback
    {
        public OnBackPress() : base(true) { }

        public override void HandleOnBackPressed()
        {
            //Add a breakpoint here or review console.
            Console.WriteLine("On back pressed.");
        }
    }
}