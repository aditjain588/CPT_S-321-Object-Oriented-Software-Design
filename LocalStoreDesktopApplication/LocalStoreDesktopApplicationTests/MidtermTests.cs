using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LocalStoreDesktopApplication
{
    namespace NUnitTestProject2
    {
        /// <summary>
        /// This class runs the test for ProductStock class's search method. 
        /// There are no tests for restock function as that function deals with user interface, it takes input from user at 3 different decision points.
        /// There are no tests for savesearch as well, as it is void type and it stores result in a local file.
        /// </summary>
        public class MidtermTests
        {
            [SetUp]
            public void Setup()
            {
            }
            /// <summary>
            /// First test for search method.
            /// </summary>
            [Test]
            public void FirstSearchTest()
            {
                //[4, (pencil, 20, description)]
                Dictionary<string, Tuple<string, int, string>> dict = new Dictionary<string, Tuple<string, int, string>>();
                dict.Add("1", new Tuple<string, int, string>("pen", 5, "description"));
                dict.Add("2", new Tuple<string, int, string>("paper", 10, "description"));
                dict.Add("3", new Tuple<string, int, string>("notebook", 2, "description"));
                string[] sub = { "1", "p" };
                ProductStock p = new ProductStock();
                var res = p.Search(dict, sub, "AND");
                var arlist = new ArrayList() { };
                foreach  (var item in dict)
                {
                    if (item.Key == "1")
                    {
                        arlist.Add(item);
                    }
                }
                
                Assert.AreEqual(res, arlist);
            }

            [Test]
            public void SecondSearchTest()
            {
                //[4, (pencil, 20, description)]
                Dictionary<string, Tuple<string, int, string>> dict = new Dictionary<string, Tuple<string, int, string>>();
                dict.Add("1", new Tuple<string, int, string>("pen", 5, "description"));
                dict.Add("2", new Tuple<string, int, string>("paper", 10, "description"));
                dict.Add("3", new Tuple<string, int, string>("notebook", 2, "description"));
                string[] sub = { "4", "pa" };
                ProductStock p = new ProductStock();
                var res = p.Search(dict, sub, "OR");
                var arlist = new ArrayList() { };
                foreach (var item in dict)
                {
                    if ((item.Key == "2") || (item.Key=="4"))
                    {
                        arlist.Add(item);
                    }
                }

                Assert.AreEqual(res, arlist);
            }

            [Test]
            public void ThirdSearchTest()
            {
                Dictionary<string, Tuple<string, int, string>> dict = new Dictionary<string, Tuple<string, int, string>>();
                dict.Add("1", new Tuple<string, int, string>("pen", 5, "description"));
                dict.Add("2", new Tuple<string, int, string>("paper", 10, "description"));
                dict.Add("3", new Tuple<string, int, string>("notebook", 2, "description"));
                string[] sub = { "10" };
                ProductStock p = new ProductStock();
                var res = p.Search(dict, sub, "OR");
                var arlist = new ArrayList() { };
                
                Assert.AreEqual(res, arlist);
            }
            
        }
    }
}