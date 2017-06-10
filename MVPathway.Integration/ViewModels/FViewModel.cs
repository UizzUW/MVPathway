﻿using MVPathway.Integration.Services.Contracts;
using MVPathway.Integration.ViewModels.ViewObjects;
using MVPathway.MVVM.Abstractions;
using MVPathway.Navigation.Abstractions;
using MVPathway.Utils.ViewModels.ViewObjects;
using Xamarin.Forms;

namespace MVPathway.Integration.ViewModels
{
    public class FViewModel : _ViewModel
    {
        public override Color Color => FColor;

        public FViewModel(INavigator navigator,
                          IDiContainer container,
                          IViewModelDefiner vmDefiner,
                          ICacheService cacheService,
                          LogViewObject log,
                          NavigationStackDebuggerViewObject stackDebugger)
            : base(navigator, container, vmDefiner, cacheService, log, stackDebugger)
        {
        }
    }
}
