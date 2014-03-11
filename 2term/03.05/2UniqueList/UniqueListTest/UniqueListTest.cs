using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2UniqueList;

namespace NUniqueListTest
{
    [TestClass]
    public class UniqueListTest
    {
        [TestMethod]
        public void AddExistElementTest()
        {
            UniqueList list = new UniqueList();
            list.AddElement(2);
            try
            {
                list.AddElement(2);
            }
            catch (ExceptionUniqueList)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void DeleteNotExistElementTest()
        {
            UniqueList list = new UniqueList();
            try
            {
                list.DeleteElement(3);
            }
            catch (ExceptionUniqueList)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }
    }
}
