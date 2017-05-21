﻿using MVPathway.Navigation.Abstractions;
using MVPathway.Presenters.Abstractions;
using MVPathway.Utils.ViewModels.ViewObjects;
using Xamarin.Forms;

namespace MVPathway.Integration.ViewModels
{
    public class CViewModel : _ViewModel
    {
        public override string Title => "C";
        public override Color Color => CColor;

        public CViewModel(INavigator navigator, NavigationStackDebuggerViewObject stackDebugger)
            : base(navigator, stackDebugger)
        {
        }
    }
}
