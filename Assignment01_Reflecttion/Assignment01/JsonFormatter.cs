using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel;
//For Testing 
using System.Text.Json;
using System.Text.Json.Serialization;
namespace Assignment01
{
    public class JsonFormatter
    {

       public static string Convert(object item)
        {
            //Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = item.GetType();
            List<string> names = new List<string>();
            List<string> values = new List<string>();
            PropertyInfo[] property = type.GetProperties();
            
            string last = "";
            foreach (var a in property)
            {
                
                if (!a.GetType().Name.Contains("List") || !a.GetType().Name.Contains("AdmissionTest") 
                    || !a.GetType().Name.Contains("Course")|| !a.GetType().Name.Contains("Instructor")
                    || !a.GetType().Name.Contains("Phone")
                    )
                {
                    names.Add(a.GetType().Name);
                    values.Add(a.GetValue(a.Name).ToString());

                }
                else if (a.GetType().Name.Contains("List"))
                {
                   
                }
                else 
                {
                    values.Add(Convert(a));
                    //values.Add(a.GetType().GetFields());
                }
            }


            //foreach (var p in type.GetProperties())
            //{
            //    Console.WriteLine($"{p.Name}: {p.GetValue(p.Name)}");
            //}

            //property[0].GetValue();

            return $"{type.Name}\": {type}";
        }

        public static string listCovert(List<object> all)
        {
            return null;
        }
    }
}
