using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class exam
    {
        internal static void InternalV()
        {
            Console.WriteLine("Internal");
        }
        public static void PublicV()
        {
            Console.WriteLine("public");
        }
        private static void PrivateV()
        {
            Console.WriteLine("Private");
        }
        protected static void ProtectedV()
        {
            Console.WriteLine("Protected");
        }
        /*public static void Main()
        {
            exam.InternalV();
            exam.PublicV();
            exam.PrivateV();
            exam.ProtectedV();
        }*/

    }
    public class innerclass
    {
       /* public static void Main()
        {
            exam.InternalV();
            exam.PublicV();
        }*/
    }

    public class Outerclass : exam
    {
        /*public static void Main()
        {
            exam.InternalV();
            exam.PublicV();
            exam.ProtectedV();
        }*/
    }
}
