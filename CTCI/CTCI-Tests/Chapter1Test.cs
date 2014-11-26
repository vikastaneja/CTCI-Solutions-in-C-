using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CTCI;
namespace CTCI.Tests
{
    [TestClass()]
    public class Chapter1Test
    {
        private Chapter1 chapter1 = null;

        [TestInitialize()]
        public void TestInitalize()
        {
            if (this.chapter1 == null)
            {
                this.chapter1 = new Chapter1();
            }
        }

        [TestCleanup()]
        public void TestCleanup()
        {
            this.chapter1 = null;
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Q1_AllUniqueWithDictionaryTestNullInput()
        {
            this.chapter1.Q1_AllUniqueWithDictionary(null);
        }

        [TestMethod()]
        public void Q1_AllUniqueWithDictionaryTestEmptyInput()
        {
            Assert.IsTrue(this.chapter1.Q1_AllUniqueWithDictionary(string.Empty), "Input string null is returning false");
        }

        [TestMethod()]
        public void Q1_AllUniqueWithDictionaryTestAllUniqueInput()
        {
            Assert.IsTrue(this.chapter1.Q1_AllUniqueWithDictionary("string.Empy"), "Input string with all unique is returning false");
        }

        [TestMethod()]
        public void Q1_AllUniqueWithDictionaryTestNonUniqueInput()
        {
            Assert.IsFalse(this.chapter1.Q1_AllUniqueWithDictionary("string.Empties"), "Input string with non-unique is returning true");
        }
    }
}
