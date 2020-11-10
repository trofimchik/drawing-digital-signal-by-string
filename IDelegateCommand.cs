using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace DigitalSignalDrawer
{
    interface IDelegateCommand : ICommand
    {
        void RaiseCanExecuteChanged();
    }
}
