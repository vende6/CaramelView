using CaramelView.Models;
using CaramelView.PageModels;

namespace CaramelView.Pages;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}