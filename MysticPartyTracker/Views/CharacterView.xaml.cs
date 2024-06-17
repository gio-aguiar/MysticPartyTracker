using MysticPartyTracker.ViewModels;

namespace MysticPartyTracker.Views;

public partial class CharacterView : ContentPage
{
	public CharacterView()
	{
		InitializeComponent();
		BindingContext = new CharacterViewModel();
	}
}