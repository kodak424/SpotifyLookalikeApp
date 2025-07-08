using CommunityToolkit.Mvvm.Input;
using SpotifyLookALike.Models;

namespace SpotifyLookALike.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}