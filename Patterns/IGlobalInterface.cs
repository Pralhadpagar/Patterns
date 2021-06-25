using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    /// <summary>
    /// should be public or internal
    /// </summary>
  public interface IGlobalInterface
    {
       void onException();

        // no constructor
        //public IGlobalInterface()
        //{

        //}

       //int name { get; set; }

      // event EventHandler ShapeChanged;
        // not possible 
        //public delegate int MyDelegate(int a, int b);
    }
}
