using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton;

// The Singleton should always be a 'sealed' class to prevent class
// inheritance through external classes and also through nested classes.
public sealed class Singleton
{
    // The Singleton's constructor should always be private to prevent
    // direct construction calls with the `new` operator.
    private Singleton() { }

    // The Singleton's instance is stored in a static field. 
    private static Singleton? _instance;

    // This is the static method that controls the access to the singleton
    // instance.
    public static Singleton GetInstance()
    {
        if (_instance is null)
            _instance = new Singleton();
        
        return _instance;
    }

    // Finally, any singleton should define some business logic, which can
    // be executed on its instance.
    public static void SomeBusinessLogic()
    {
        // ...
    }
}
