﻿using MVPathway.Navigation.Abstractions;
using MVPathway.Presenters.Abstractions;
using MVPathway.Utils.ViewModels.ViewObjects;
using Xamarin.Forms;

namespace MVPathway.Integration.ViewModels
{
    public class EViewModel : _ViewModel
    {
        public override string Title => "E";
        public override Color Color => EColor;

        public EViewModel(INavigator navigator, NavigationStackDebuggerViewObject stackDebugger)
            : base(navigator, stackDebugger)
        {
        }
    }
}
