using System;
using System.Numerics;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoNET;
using System.Text;
using System.Collections.Generic;
using AlgoNET.Fakes;

namespace AlgoNETTests {
    [TestClass]
    public class FibModuleTest {
        public TestContext TestContext { get; set; }

        FibModule test_fib;
        ulong result;
 
        [TestInitialize]
        public void TestInitialize() {
            test_fib = new FibModule();
        }

        // Data driven test for terms and values and first class of assertion - equal
        // Test if textbook method gives correct result to all given cases
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"Data\nth_term_slow.csv", "nth_term_slow#csv", DataAccessMethod.Sequential)]
        // [DeploymentItem("AlgoNET\\Data\nth_term.csv")]
        public void return_right_value_for_textbook_method() {
            ulong term = Convert.ToUInt64(Convert.ToString(TestContext.DataRow["term"]));
            ulong predicted_value = Convert.ToUInt64(Convert.ToString(TestContext.DataRow["value"]));
            Assert.AreEqual(test_fib.textbook(term), predicted_value);
        }

        // Second class of assertion - exeption
        // Test if textbook method raise errors for arguments bigger than 40
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void raise_argument_error_for_textbook_method() {
            // Fake? array is an in-memory collection
            ulong []terms = {4, 10, 20, 41, 42, 50, 100, 3, 100001, 200567};
            foreach (ulong term in terms) {
                result = test_fib.textbook(term);
            }
            Assert.Fail();
        }

        // Data driven test for terms and values, third class of assertion - string starts with value
        // Test if fast doubling method gives correct result to all given cases
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"Data\nth_term_fast.csv", "nth_term_fast#csv", DataAccessMethod.Sequential)]
        public void return_right_value_for_fast_doubling_method() {
            ulong term = Convert.ToUInt64(Convert.ToString(TestContext.DataRow["term"]));
            string predicted_value = Convert.ToString(TestContext.DataRow["value"]);
            StringAssert.StartsWith((test_fib.fast_doubling(term)).ToString("D"), predicted_value);
        }

        // Using small stubs
        // Test if methods gives the same answer
        [TestMethod]
        public void compare_methods_for_40() {
            var fib_stub = new StubIFibModule()
            {
                TextbookUInt64 = (n) => { return 102334155; }
    
            };
            Assert.AreEqual(test_fib.fast_doubling(40).ToString("D"), fib_stub.TextbookUInt64(40).ToString("D"));
        }

        // Fourth class of assertion - collection
        // Check if list is correct in small range
        [TestMethod]
        public void check_small_range_of_fib() {
            List<String> test_list = new List<String>() { "1", "1", "2", "3", "5" };
            var result_list = test_fib.get_values_from_range(1, 5);
            CollectionAssert.AreEqual(test_list, result_list);
        }

        // Check if list is correct in big range
        [TestMethod]
        public void check_big_range_of_fib() {
            List<String> test_list = new List<String>() { "119447720249892581203851665820676436622934188700177088360",
                                                          "193270471243015279782059101964580241188515112465021394429",
                                                          "312718191492907860985910767785256677811449301165198482789"
                                                        };
            var result_list = test_fib.get_values_from_range(270, 272);
            CollectionAssert.AreEqual(test_list, result_list);
        }

        // Check if list can be only one element/value
        [TestMethod]
        public void check_one_element_range_of_fib() {
            List<String> test_list = new List<string>() { "81055900096023504197206408605" };
            var result_list = test_fib.get_values_from_range(140, 140);
            CollectionAssert.AreEqual(test_list, result_list);
        }

        // Test if error is raised when b is smaller than a
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void raise_argument_error_for_get_values_from_range() {
            List<String> test_list = test_fib.get_values_from_range(100, 20);
            Assert.Fail();
        }

        [TestCleanup]
        public void TestCleanup() {
            test_fib = null;
            result = 0;
        }
    }
}