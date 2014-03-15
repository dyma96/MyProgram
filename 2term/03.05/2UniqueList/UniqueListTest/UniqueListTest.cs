using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2UniqueList;

namespace NUniqueListTest
{
    [TestClass]
    public class UniqueListTest
    {
        [TestMethod]
        [ExpectedException(typeof(ExceptionUniqueList))]
        public void AddExistElementTest()
        {
            UniqueList list = new UniqueList();
            list.AddElement(2);
            list.AddElement(2);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionUniqueList))]
        public void DeleteNotExistElementTest()
        {
            UniqueList list = new UniqueList();
            list.DeleteElement(3);
        }
    }
}
