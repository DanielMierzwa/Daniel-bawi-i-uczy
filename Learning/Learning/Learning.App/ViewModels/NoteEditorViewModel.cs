using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.App.ViewModels
{
    public partial class NoteEditorViewModel : ObservableObject
    {
        [ObservableProperty]
        string title;
        [ObservableProperty]
        string content;

        [RelayCommand]
        public async Task Save()
        {
            await Shell.Current.DisplayAlert(Title,Content,"ok");
        }
    }
}
