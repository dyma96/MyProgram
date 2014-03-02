using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hash.Test
{
    using _2HashTableWithFunction;
   
    /// <summary>
    /// Test Hash table. 
    /// </summary>
    [TestClass]
    public class HashTest
    {
        [TestInitialize]
        public void Initialize()
        {
            hash = new HashTable(10, 1);
        }

        [TestMethod]
        public void AddToHashTableTest()
        {
            hash.AddToHashTable(1);
            Assert.IsTrue(hash.Exist(1));
        }

        [TestMethod]
        public void DeleteElementTest()
        {
            hash.AddToHashTable(1);
            hash.DeleteElement(1);
            Assert.IsFalse(hash.Exist(1));
        }

        [TestMethod]
        public void DeleteElementInEmptyHashTest()
        {
            hash.DeleteElement(1);
            Assert.IsFalse(hash.Exist(1));
        }

        private HashTable hash;
    }
}
