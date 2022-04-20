using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State;

// The base State class declares methods that all Concrete State should
// implement and also provides a backreference to the Context object,
// associated with the State. This backreference can be used by States to
// transition the Context to another State.
abstract class State
{
    protected Context _context;

    public void SetContext(Context context) => _context = context;

    public abstract void Handle1();

    public abstract void Handle2();
}