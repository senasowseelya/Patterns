using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class ReflectionExample
    {

        public int Age { get; set; }
        public string  Name { get; set; }
        internal void Display()
        {
            Console.WriteLine(Age.GetType());
            DateTime dateTime = (DateTime)Activator.CreateInstance(typeof(DateTime));
            Assembly assembly = Assembly.LoadFile("C:\\Users\\senasowseelya.v\\source\\repos\\CQRS\\RepositoryPattern\\RepositoryPattern\\bin\\Debug\\net8.0\\RepositoryPattern.dll");
            Console.WriteLine(assembly.FullName.ToString());
           //var d = assembly.GetTypes();
            Type t = assembly.GetType("RepositoryPattern.Models.Student");
            var instance = Activator.CreateInstance(t);
            PropertyInfo propertyInfo = t.GetProperty("Name");
            PropertyInfo propertyInfo1 = t.GetProperty("Age");
            propertyInfo.SetValue(instance, "Sena");
            propertyInfo1.SetValue(instance, 10);
            Console.WriteLine( propertyInfo.GetValue(instance));
            Console.WriteLine( propertyInfo1.GetValue(instance));
            foreach (var item in t.GetMembers())
            {
                Console.WriteLine(item.Name);
            }
            foreach (var item in assembly.GetModules())
            {
                
                Console.WriteLine(item.Name);
            }
            
        }

    }
}
