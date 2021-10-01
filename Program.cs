using System;

namespace DefiningClassMembers3
{
    /* Class: MyClass
     * Author: Jonathan Karcher
     * Purpose: Return a string
     */
    public class MyClass
    {
        private string myString = "Parent string";
        /* Method: GetString
         * Purpose: Return this myString
         * Restrictions: None
         */
        public virtual string GetString()
        {
            return this.myString;
        }
    }
    /* Class: MyDerivedClass
     * Author: Jonathan Karcher
     * Purpose: Return a string
     */
    public class MyDerivedClass : MyClass
    {
        private string myString = " (output from the derived class)";
        /* Method: GetString
         * Purpose: Return the parent mystring and this myString
         * Restrictions: None
         */
        public override string GetString()
        {
            return base.GetString() + this.myString;
        }
    }
    /* Class: Program
     * Author: Jonathan Karcher
     * Purpose: output a string
     */
    class Program
    {
        /* Method: Main
         * Purpose: Make a MyDerivedClass and output its GetString
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            // make a derived class
            MyDerivedClass m = new MyDerivedClass();
            // output the result
            Console.WriteLine(m.GetString());
        }
    }
}
