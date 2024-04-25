using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class DelegateExample
    {
        public void DisplayVariable(int a)
        {
            Console.WriteLine("Value of variable is " + a);
        }

        public void IncrementVariable(int a)
        {
            Console.WriteLine("Value of variable  after increment is " + ++a);

        }

        public void DecrementVariable(int a)
        {
            Console.WriteLine("Value of variable after decrement is " + --a);
        }
        public void DelegateEvent(int a , SampleDelegate sampleDelegate)
        {
            sampleDelgateEvent(a);
        }

        public Action SampleAction;
        public event SampleDelegate sampleDelgateEvent;

        public delegate void SampleDelegate(int x);

        public void InvokeDelegate()
        {
   
            //sampleDelgateEvent = DisplayVariable;
            //DelegateEvent(10, sampleDelgateEvent);
           // sampleDelgateEvent.Invoke(10);
        //    SampleDelegate sample = DisplayVariable;
        //    sample += IncrementVariable;
        //    sample += DecrementVariable;
        //    sample += Program.MethodFromProgram;
        //    sample.Invoke(10);
        //
        }
    }

    public class FuncExample
    {
        public delegate string ConvertCase(string s);
        Func<string, string> convertCaseFunc;
        public string ConvertToUpperCase(string s)
        {
             return s.ToUpper();
        }
        public string ConvertToLower(string s)
        {
            return s.ToLower();
        }
        public void InvokeFunc()
        {
            ConvertCase convertCase = ConvertToUpperCase;
            Console.WriteLine(convertCase("Sena"));

            convertCaseFunc += ConvertToUpperCase;
            convertCaseFunc = ConvertToLower;
            convertCaseFunc += ConvertToLower;

            Console.WriteLine(convertCaseFunc("SENA"));
          
        }
    }
}
