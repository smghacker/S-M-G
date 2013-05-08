using System;

namespace Abstraction
{
    //We reach good level of abstraction through interface because we can't know how the perimeter or surface is calculated
    //so we don't know which properties to include in the abstract class, 
    //and so when we have only methods it is better to define an interface
    public interface IFigure
    {
        double CalcPerimeter();
        double CalcSurface();
    }
}
