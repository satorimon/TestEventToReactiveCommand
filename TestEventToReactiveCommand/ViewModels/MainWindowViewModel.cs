using Prism.Mvvm;
using Reactive.Bindings;
using System.Reactive.Linq;

namespace TestEventToReactiveCommand.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ReactiveCommand<MousePosition> MouseMoveCommand { get; }

        public ReadOnlyReactivePropertySlim<string> Message { get; }

        public MainWindowViewModel()
        {
            MouseMoveCommand = new ReactiveCommand<MousePosition>();
            Message = MouseMoveCommand.Select(x => $"({x.X}, {x.Y})")
                .ToReadOnlyReactivePropertySlim();
        }
    }
}
