using CommunityToolkit.Mvvm.Input;
using CaramelView.Models;

namespace CaramelView.PageModels;

public interface IProjectTaskPageModel
{
	IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
	bool IsBusy { get; }
}