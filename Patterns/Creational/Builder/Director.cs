using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder;

public  class Director
{
    private IBuilder _builder;

    public IBuilder Builder
    {
        set => _builder = value;
    }

    // The Director can construct several product variations using the same
    // building steps.
    public void BuildMinimalViableProduct() => _builder.BuildPartA();
    
    public void BuildFullFeaturedProduct()
    {
        _builder.BuildPartA();
        _builder.BuildPartB();
        _builder.BuildPartC();
    }
}