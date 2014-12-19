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

        [TestMethod()]
        public void Q3_StringsAreNull()
        {
            Assert.IsTrue(this.chapter1.Q3_OneStringPermutationOfOther(null, null), "Input strings as null is returning false");
        }

        [TestMethod()]
        public void Q3_StringssAreEmpty()
        {
            Assert.IsTrue(this.chapter1.Q3_OneStringPermutationOfOther(string.Empty, string.Empty), "Input string as empty is returning false");
        }

        [TestMethod()]
        public void Q3_OneStringIsNullOtherEmpty()
        {
            Assert.IsFalse(this.chapter1.Q3_OneStringPermutationOfOther(string.Empty, null), "Input strings as null and empty is returning true");
        }

        [TestMethod()]
        public void Q3_StringAreAnagrams()
        {
            Assert.IsTrue(this.chapter1.Q3_OneStringPermutationOfOther("abcdddddcbb", "bccdddddbba"), "Input string as anagrams is returning false");
        }

        [TestMethod()]
        public void Q3_StringAreNotAnagrams()
        {
            Assert.IsFalse(this.chapter1.Q3_OneStringPermutationOfOther("abcdddddcbb", "bccdddddbbb"), "Input string as non anagrams is returning true");
        }

        [TestMethod()]
        public void Q3_StringOfUnequalLengths()
        {
            Assert.IsFalse(this.chapter1.Q3_OneStringPermutationOfOther("abcdddddcbb", "bccdddddbb"), "Input string as anagrams is returning true");
        }

        [TestMethod()]
        public void Q3_StringWithNullAndNonNull()
        {
            Assert.IsFalse(this.chapter1.Q3_OneStringPermutationOfOther(null, "bccdddddbb"), "Input string one as null is returning true");
        }
    }
}
