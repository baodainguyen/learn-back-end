using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoDotNetCore
{
    public class CloneCopyPrototypeDemo
    {
        public static void RunDemo() {
            var objA = new ClassA("originalA", new ClassA1("nestedPropA", "nestedPropB"));
            var objAClone = objA.DeepCopy();
            objAClone.SetProps("changed objectProp on clone", "changed nestedPropB on clone");            
            objA.DeepPrintObject();
            objAClone.DeepPrintObject();


            var objB = new ClassB("originalB", new ClassB1("nestedPropC", "nestedPropD"));
            var objBClone = (ClassB)objB.Clone();
            objBClone.SetProps("changed objectProp on cloneB1", "changed nestedPropD on cloneB1");
            objB.DeepPrintObject();
            objBClone.DeepPrintObject();
        }
    }

    // use Newtonsoft.Json (SerializeObject)
    public class ClassA : iDo
    {
        public ClassA(string objectProp, ClassA1 nestedObjectProp)
        {
            ObjectProp = objectProp;
            classA1 = nestedObjectProp;
        }
        public void SetProps(string objectProp, string NestedPropB)
        {
            ObjectProp = objectProp;
            classA1.NestedPropB = NestedPropB;
        }
        public string ObjectProp { get; set; }
        public ClassA1 classA1 { get; set; }
    }
    public class ClassA1
    {
        public ClassA1(string nestedPropA, string nestedPropB)
        {
            NestedPropB = nestedPropB;
            NestedPropA = nestedPropA;
        }
        public string NestedPropA { get; set; }
        public string NestedPropB { get; set; }
    }
    public interface iDo{
        public void SetProps(string objectProp, string NestedPropB);
    }

    // Implement the ICloneable interface
    public class ClassB : iDo, ICloneable
    {
        public ClassB(string objectProp, ClassB1 nestedObjectProp)
        {
            ObjectProp = objectProp;
            classB1 = nestedObjectProp;
        }
        public void SetProps(string objectProp, string NestedPropB)
        {
            ObjectProp = objectProp;
            classB1.NestedPropB = NestedPropB;
        }
        public object Clone()
        {
            return new ClassB(ObjectProp, (ClassB1)classB1.Clone());
        }
        public string ObjectProp { get; set; }
        public ClassB1 classB1 { get; set; }
    }
    public class ClassB1 : ICloneable
    {
        public ClassB1(string nestedPropA, string nestedPropB)
        {
            NestedPropB = nestedPropB;
            NestedPropA = nestedPropA;
        }
        public object Clone()
        {
            return new ClassB1(NestedPropA, NestedPropB);
        }
        public string NestedPropA { get; set; }
        public string NestedPropB { get; set; }
    }

    public static class CloneExtends
    {
        public static void DeepPrintObject<T>(this T obj)
        {
            Console.WriteLine("Class: {0}", typeof(T).Name);
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(obj))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(obj);

                if (typeof(ClassA1).IsInstanceOfType(value))
                {
                    Console.Write("  ");
                    ((ClassA1)value).PrintObject();
                } 
                else if (typeof(ClassB1).IsInstanceOfType(value))
                {
                    Console.Write("  ");
                    ((ClassB1)value).PrintObject();
                }
                else
                {
                    Console.WriteLine("   {0} = {1}", name, value);
                }
            }
        }
    }
}
