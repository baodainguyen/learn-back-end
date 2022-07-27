using System;
using System.ComponentModel;

using Newtonsoft.Json;

namespace ConsoleDemoDotNetCore
{
    public static class Extentions
    {
        public static void PrintObject<T>(this T obj) {
            Console.WriteLine("Class: {0}", typeof(T).Name);
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(obj))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(obj);
                Console.WriteLine("   {0} = {1}", name, value);
            }
        }

        // Ham nay copy cac propoties va function cua class
        public static T DeepCopy<T>(this T self)
        {
            var serialized = JsonConvert.SerializeObject(self);
            return JsonConvert.DeserializeObject<T>(serialized);
        }
    }
}
