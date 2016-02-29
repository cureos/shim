using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.ServiceModel;
using System.Threading;
using System.Windows;

namespace System
{
    /// <summary>
    /// Simple compilation tests.
    /// </summary>
    internal static class TestNamespaces
    {
        /// <summary>
        /// Tests the xamarin namespaces.
        /// </summary>
        static void TestExistingNamespaces()
        {
            DateTime testDateTime = new DateTime();
            testDateTime.ToShortDateString();

            Mutex testMutex = new Mutex();
            testMutex.Close();

            int testInt = 0;
            testInt.CompareTo(1);

            Guid testGuid = Guid.NewGuid();
            testGuid.ToString("N", NumberFormatInfo.CurrentInfo);

            string testString = "test";
            char firstChar = testString.First();

            bool testBool = true;
            testBool.ToString(CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Tests the faked namespaces.
        /// </summary>
        static void TestFakedNamespaces()
        {
            ExcludeFromCodeCoverageAttribute testExcludeFromCodeCoverageAttribute = new ExcludeFromCodeCoverageAttribute();

            CallbackBehaviorAttribute testCallbackBehaviorAttribute = new CallbackBehaviorAttribute();

            Point testPoint = new Point(0d, 0d);
        }
    }
}