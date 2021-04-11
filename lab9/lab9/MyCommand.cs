using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace lab9
{
    public static class MyCommand 
    {
        static RoutedUICommand exitMessage = new RoutedUICommand(
            "Exit", "ExitMessage", typeof(MyCommand));
        public static RoutedUICommand ExitMessage { get { return exitMessage; } }
    }
}
