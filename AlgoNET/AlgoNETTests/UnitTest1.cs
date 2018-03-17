using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoNET;

namespace AlgoNETTests {
    [TestClass]
    public class FibModuleTest {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"Data\nth_term.csv", "nth_term#csv", DataAccessMethod.Sequential)]
        // [DeploymentItem("AlgoNET\\Data\nth_term.csv")]
        // Data driven test for terms and values and one class of assertion
        public void return_right_value_for_textbook_method() {
            FibModule test_fib = new FibModule();
            ulong term = Convert.ToUInt64(Convert.ToString(TestContext.DataRow["term"]));
            ulong predicted_value = Convert.ToUInt64(Convert.ToString(TestContext.DataRow["value"]));
            ulong result = test_fib.calc_nth_term_textbook(term);
            Assert.AreEqual(result, predicted_value);
        }
    }
}