using Assignment_1.Class;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n" + new string('-', 70) + "\n");
            Console.WriteLine("Assignment Adv 01");
            Console.WriteLine("\n" + new string('-', 70) + "\n");

            #region Assignment

            #region Question 01

            /*
             * ----------------------
             * Q1: What is a generic class? 
             * ----------------------
             * A generic class is a class that works with any data type using a placeholder type (e.g., T).
             * 
             * ----------------------
             * Why use generics?
             * ----------------------
             * Code reusability 
             * Type safety (no casting needed) 
             * Better performance (no boxing/unboxing)
             * 
             */

            #endregion

            #region Question 03

            /*
             * Q3: What are multiple type parameters? 
             * -----------------------
             * Generic classes can have multiple type parameters. 
             * 
             * Common examples: Dictionary<TKey, TValue>, Tuple<T1, T2>
             * 
             * ------------------------
             * Write Pair<TKey, TValue>.
             * ------------------------
             */


            #endregion

            #region Question 04

            /*
             * Q4: What is a generic method? 
             * -------------------------
             * A generic method declares its own type parameter(s). 
             * It can exist in both generic and non-generic classes. 
             * The compiler often infers the type argument.
             * 
             * -----------------------
             * Write Swap<T> method.
             * 
             */

            //int x = 5, y = 10;
            //Console.WriteLine($"x = {x}, y = {y}\n"); // x=5, y=10
            //Swap(ref x, ref y);  // Compiler infers T = int
            //Console.WriteLine($"After Swap : x = {x}, y = {y}\n"); // x=10, y=5

            //string a = "Hello", b = "World";
            //Console.WriteLine($"a = {a}, b = {b}\n"); // a=Hello, b=World
            //Swap<string>(ref a, ref b); // Explicit type
            //Console.WriteLine($"After Swap : a = {a}, b = {b}\n"); // a=World, b=Hello

            #endregion

            #region Question 05

            /*
             * Q5: Write a generic method FindMax<T> that finds maximum value
             * 
             * 
             */

            //Console.WriteLine("Max of 3 and 7 is: " + FindMax(3, 7)); 

            #endregion

            #region Question 06

            /*
             * Q6: What is a generic interface? 
             * -------------------------
             * Generic interfaces define contracts with type parameters. 
             * Classes implementing them specify the actual types.
             * 
             * ------------------------
             * Write IRepository<T>.
             * 
             * 
             */

            #endregion

            #region Question 07

            /*
             * Q7: What is the 'struct' constraint? 
             * --------------------------
             * Constraints restrict which types can be used as type arguments. 
             * This enables you to call specific methods on the type parameter.
             * 
             * Constraint ==> where T : struct
             * 
             * Description ==> The 'struct' constraint restricts T to value types only. 
             * Useful when you need value semantics (copy, no null).
             * 
             * 
             * -------------------------
             * Write an example.
             * 
             */

            #endregion

            #region Question 08

            /*
             *  Q8: What is the 'class' constraint? 
             *  --------------------------
             *  where T : class restricts T to reference types only. 
             *  This allows T to be null and enables reference comparison.
             *  
             *  
             *  --------------------------
             *  Write an example.
             */

            #endregion

            #region Question 09

            /*
             *  Q9: What is the 'new()' constraint? 
             *  --------------------------
             *  where T : new() requires T to have a public parameterless constructor. 
             *  This allows you to create instances of T inside the generic code.
             *  
             *  --------------------------
             *  Write an example.
             */

            #endregion

            #region Question 10

            /*
             * Q10:  What is the interface constraint? 
             * ---------------------------
             * where T : IInterface requires T to implement a specific interface. 
             * This enables calling interface methods on type parameter.
             * 
             * 
             * ---------------------------
             * Write an example.
             */

            #endregion

            #region Question 11

            /*
             *   Q11: What is the base class constraint? 
             *   ---------------------------
             *   
             *   where T : BaseClass , requires T to inherit from a specific base class.
             *   
             *   The type used for T must be this class or any class derived from it.
             *   
             *   --------------------------
             *   Write an example.
             *   ---------------------------
             *   public class Animal { }
             *
             *   public class Dog : Animal { }
             *   
             *   public class AnimalHandler<T> where T : Animal
             *   {
             *       public void Handle(T animal) { }
             *   }
             *   
             *   
             */

            #endregion

            #region Question 12

            /*
             *  Q12: How do you apply multiple constraints? 
             *  ----------------------------
             *  You can combine multiple constraints for a single type parameter, 
             *  and have different constraints for different type parameters.
             *  
             *  ----------------------------
             *  Write an example.
             * ------------------------------
             * 
             * public class Example<T> where T : class, IDisposable, new()
             * {
             *     public T CreateAndUse()
             *     {
             *         T obj = new T();
             *         obj.Dispose();
             *         return obj;
             *     }
             * }
             *           
             */

            #endregion

            #region Question 13

            /*
             *  Q13: What does the 'default' keyword do in generics?
             * -----------------------------
             * 
             * Returns the default value of a type:
             * ==>  0 for numbers
             * ==>  false for bool
             * ==>  null for reference types
             * 
             * 
             * Use default when you need to initialize or return a "zero" value without knowing the type.
             */

            #endregion

            #region Question 14

            /*
             * Q14: Write a SafeList<T> that returns default when the index is invalid.
             * 
             */

            //SafeList<string> names = new SafeList<string>();

            //names.Add("Ali");
            //names.Add("Sara");

            //Console.WriteLine($"names.Get(0)  ==>  {names.Get(0)}"); // Ali

            //// Invalid index → returns default (null for string)
            //Console.WriteLine($"names.Get(5)  ==>  {names.Get(5) ?? "No value"}"); // No value

            #endregion

            #region Question 15

            /*
             *  Q15: What is covariance? 
             *  ------------------------
             *  Covariance allows you to use a more derived type than originally specified. 
             *  
             *  -----------------------
             *  Explain the 'out' keyword.
             * ------------------------
             *  Marked with out keyword. T can only appear in output positions.
             *              
             * Allows using a more derived type.  You can return T but not accept it as a parameter.
             * 
             * public interface IProducer<out T>
             * {
             *     T Get();
             * }
             * 
             */

            #endregion

            #region Question 16

            /*
             * Q16: What is contravariance? Explain the 'in' keyword.
             * -------------------------
             * Contravariance allows you to use a less derived type than originally specified. 
             * Marked with in keyword. T can only appear in input positions.
             * 
             * Allows using a less derived type. You can accept T as a parameter but not return it.
             * 
             * public interface IConsumer<in T>
             * {
             *     void Set(T item);
             * }
             * 
             */

            #endregion

            #region Question 17

            /*
             * Q17: What is the difference between covariance and contravariance?
             * 
             * 
             */

            #endregion

            #region Question 18

            /*
             * Q18: How do static members work in generic types?
             * 
             * 
             */

            #endregion

            #region Question 19

            /*
             * Q19: How can you inherit from a generic class?
             * 
             * 
             */

            #endregion

            #region Question 20

            /*
             * Q20: Complete Exercise - Create a generic Cache<TKey, TValue> 
             * with Add, Get, Remove, Contains, and expiration support. 
             * 
             * 
             */

            #endregion

            #endregion

            Console.WriteLine("\n" + new string('-', 70) + "\n");
        }

        #region Helpful Methods

        #region Question 04
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        #endregion

        #region Question 05
        public static T FindMax<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
        #endregion

        #endregion
    }
}
