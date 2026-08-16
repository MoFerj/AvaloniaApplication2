using AvaloniaApplication2.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaApplication2.ViewModels;

public partial class MainViewModel : ObservableObject
{
    
    public Machine Machine { get; }
    public MainViewModel()
    {
        Machine = new Machine();
        Machine.PropertyChanged += Machine_PropertyChanged;
    }
    
    [RelayCommand (CanExecute =nameof(KannStarten))]
    private void Start()
    {
        Machine.IstAn = true;
    }
    [RelayCommand(CanExecute =nameof(KannStoppen))]
    private void Stop()
    {
        Machine.IstAn = false;
    }
    private bool KannStarten()
    {
         return !Machine.IstAn;
    }
    private bool KannStoppen()
    {
        return Machine.IstAn;
    }
    private void Machine_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if(e.PropertyName==nameof(Machine.IstAn))
        {
            StartCommand.NotifyCanExecuteChanged();
            StopCommand.NotifyCanExecuteChanged();  
        }
    }
}
