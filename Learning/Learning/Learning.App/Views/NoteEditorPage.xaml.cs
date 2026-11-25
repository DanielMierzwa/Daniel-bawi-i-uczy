using Learning.App.ViewModels;

namespace Learning.App.Views;

public partial class NoteEditorPage : ContentPage
{
	public NoteEditorPage(NoteEditorViewModel vm)
	{
		BindingContext = vm;
		InitializeComponent();
	}
}