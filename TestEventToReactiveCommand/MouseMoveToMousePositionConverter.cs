using Reactive.Bindings.Interactivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace TestEventToReactiveCommand
{
    public class MouseMoveToMousePositionConverter : ReactiveConverter<MouseEventArgs, MousePosition>
    {
        protected override IObservable<MousePosition> OnConvert(IObservable<MouseEventArgs> source) => source
            .Select(x => x.GetPosition((IInputElement)AssociateObject))
            .Select(x => new MousePosition
            {
                X = x.X,
                Y = x.Y,
            });
    }
}
