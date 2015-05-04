using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Acerodon.App.Helper
{
    class Command : ICommand
    {

        public delegate void CommandName();

        private CommandName command;

        public Command(CommandName command)
        {
            this.command = command;
        }

        public event EventHandler CanExecuteChanged;


        public bool CanExecute(object parameter)
        {
            return true;
        }

        
        public void Execute(object parameter)
        {
            command.Invoke();
        }
    }
}
