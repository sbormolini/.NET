using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade;

// The Subsystem can accept requests either from the facade or client
// directly. In any case, to the Subsystem, the Facade is yet another
// client, and it's not a part of the Subsystem.
public class Subsystem1
{
    public string operation1()
    {
        return "Subsystem1: Ready!\n";
    }

    public string operationN()
    {
        return "Subsystem1: Go!\n";
    }
}

// Some facades can work with multiple subsystems at the same time.
public class Subsystem2
{
    public string operation1()
    {
        return "Subsystem2: Get ready!\n";
    }

    public string operationZ()
    {
        return "Subsystem2: Fire!\n";
    }
}