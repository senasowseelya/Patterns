// See https://aka.ms/new-console-template for more information
using Fundamentals;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, Sena!!");

        //DelegateExample example = new DelegateExample();
        ////example.sampleDelgateEvent += MethodFromProgram;
        //example.InvokeDelegate();

        //FuncExample funcExample = new FuncExample();
        //funcExample.InvokeFunc();

        ReflectionExample reflectionExample = new ReflectionExample();
        reflectionExample.Display();

        
    }
    public static void MethodFromProgram(int s)
    {
        Console.WriteLine("Method from program" + s);
    }

    
}