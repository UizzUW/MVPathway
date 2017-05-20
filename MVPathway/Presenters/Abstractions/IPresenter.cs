﻿using MVPathway.MVVM;
using MVPathway.MVVM.Abstractions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVPathway.Presenters.Abstractions
{
    public interface IPresenter
    {
        Stack<BaseViewModel> NavigationStack { get; }

        Task Init();

        Task<TViewModel> Show<TViewModel>(object parameter = null) where TViewModel : BaseViewModel;
        Task<BaseViewModel> Show(Func<ViewModelDefinition, bool> definitionFilter, object parameter = null);
        Task<BaseViewModel> Show(BaseViewModel viewModel, object parameter = null);

        Task<ViewModelResult<TResult>> GetResult<TViewModel, TResult>(object parameter = null)
          where TViewModel : BaseResultViewModel<TResult>;
        Task<ViewModelResult<TResult>> GetResult<TResult>(Func<ViewModelDefinition, bool> definitionFilter, object parameter = null);
        Task<ViewModelResult<TResult>> GetResult<TResult>(BaseResultViewModel<TResult> viewModel, object parameter = null);

        Task<BaseViewModel> Close(object parameter = null);

        Task<bool> DisplayAlertAsync(string title, string message, string okText, string cancelText = null);
    }
}
