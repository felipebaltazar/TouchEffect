﻿using System;
using Xamarin.Forms;
using TouchEffect;
namespace TouchEffectSample
{
    public class App : Application
    {
        public App()
        {
			MainPage = new NavigationPage(new SamplePage());
        }
    }
}