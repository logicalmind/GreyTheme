using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] unused)
        {
            var myClass = new MyClass("test", 100);
            var tmp = myClass.MyMethod(myClass) + myClass.MyExtension();

            Console.WriteLine(tmp);
            Console.Out.WriteLine(tmp);
        }
    }

    public class MyClass
    {
        private const int MyConstant = 1;
        private string myField;

        public int MyProperty { get; set; }

        public MyClass(string myField, int myProperty)
        {
            this.myField = myField;
            MyProperty = Math.Max(myProperty, MyConstant);
        }

        public string MyMethod(MyClass input)
        {
            Guid g = new Guid("test");
            return myField + MyProperty + MyConstant + input.MyExtension() + g.ToString();
        }
    }

    public static class MyExtentsion
    {
        public static string MyExtension(this MyClass str)
        {
            return str.ToString();
        }
    }
}
