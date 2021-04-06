using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр_67
{
    public interface ICommand
    {
        string Name { get; set; }
        void Execute();
        void UnExecute();
    }
}
