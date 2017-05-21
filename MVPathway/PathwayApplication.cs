﻿using MVPathway.Builder.Abstractions;
using MVPathway.Logging;
using MVPathway.Logging.Abstractions;
using MVPathway.Messages;
using MVPathway.Messages.Abstractions;
using MVPathway.MVVM;
using MVPathway.MVVM.Abstractions;
using MVPathway.Navigation;
using MVPathway.Navigation.Abstractions;
using MVPathway.Presenters;
using Xamarin.Forms;

namespace MVPathway
{
    public abstract class PathwayApplication : Application
    {
        public virtual void Configure(IPathwayBuilder builder)
        {
            builder.UseDiContainer<DiContainer>()
                   .UseViewModelManager<ViewModelManager>()
                   .UsePresenter<SinglePagePresenter>()
                   .UseMessagingManager<Messenger>()
                   .UseLogger<PathwayLogger>()
                   .UseNavigationBus<NavigationBus>()
                   .UseNavigator<Navigator>();
        }

        public abstract void Init(IDiContainer container,
                                   IViewModelManager vmManager,
                                   IMessenger messagingManager,
                                   INavigator navigator,
                                   ILogger logger);
    }
}
