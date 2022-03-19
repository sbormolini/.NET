using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder;

// The Builder interface specifies methods for creating the different parts
// of the Product objects.
public interface IBuilder
{
    void BuildPartA();

    void BuildPartB();

    void BuildPartC();
}
