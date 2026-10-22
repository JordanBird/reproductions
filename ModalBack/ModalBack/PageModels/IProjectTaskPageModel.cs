using CommunityToolkit.Mvvm.Input;
using MauiModalAndroidBackReproduction.Models;

namespace MauiModalAndroidBackReproduction.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}