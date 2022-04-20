using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge;

// The Abstraction defines the interface for the "control" part of the two
// class hierarchies. It maintains a reference to an object of the
// Implementation hierarchy and delegates all of the real work to this
// object.
public class Abstraction
{
    protected IImplementation _implementation;

    public Abstraction(IImplementation implementation) => _implementation = implementation;

    public virtual string Operation()
    {
        return "Abstract: Base operation with:\n" + _implementation.OperationImplementation();
    }
}