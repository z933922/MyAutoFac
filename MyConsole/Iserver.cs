using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
  public   interface Iserver
    {
        string Show();
    }

    public interface Iwrite
    {
        void Write(string name);
    }

    public interface IMY
    {
        void MyWrite(string name);
    }
}
