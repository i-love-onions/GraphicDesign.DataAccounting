using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicDesign.DataAccounting.UI
{
    struct SimpleMenuItem
    {
        public string CommandName;
        public Action Operation;
        public SimpleMenuItem(string commandName, Action operation)
        {
            this.CommandName = commandName;
            this.Operation = operation;
        }
    }
}
