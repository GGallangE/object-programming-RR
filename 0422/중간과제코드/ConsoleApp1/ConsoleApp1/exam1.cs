using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestApp0
{
    internal static class InternalClass
    {
        internal static Int32 InternalMethod()
        {
            return 777;
        }
    }

    public class TestClass
    {
        public static Int32 TestMethod()
        {
            /* 같은 어셈블리이므로 접근이 가능함 */
            return InternalClass.InternalMethod();
        }
    }
}

/* Assembly: TestApp1 */
namespace TestApp1
{
    public class TestClass
    {
        public static void TestMetho()
        {
            // InternalClass 에 접근 불가,
            // 서로 다른 어셈블리임
            TestApp0.InternalClass.InternalMethod();
        }
    }
}