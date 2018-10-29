using System;

interface IparentInterface
{
    void ParentInterfaceMethod();
}

interface IMyInterface : IparentInterface
{
    void MethodToImplement();
}

class InterfaceImplementer : IMyInterface
{
    public void MethodToImplement()
    {
        Console.WriteLine("MethodToImplement() called.");
    }

    public void ParentInterfaceMethod()
    {
        Console.WriteLine("ParentInterfaceMethod() called.");
    }

/*     static void Main()
    {
        InterfaceImplementer iImp = new InterfaceImplementer();
        iImp.MethodToImplement();
        iImp.ParentInterfaceMethod();
    } */
}