using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.IO;

namespace NParseTreeTest
{
    using _1parseTree;

    [TestClass]
    public class ParseTreeTest
    {
        [TestInitialize]
        public void Initialize()
        {
            fInfo = new FileInfo("..//..//newFile.txt");
        }

        [TestMethod]
        public void ConstructorTest()
        {
            StreamWriter fWrite = fInfo.CreateText();
            fWrite.WriteLine("( + 1 2 )");
            fWrite.Close();
        
            fRead = fInfo.OpenText();
            ParseTree tree = new ParseTree(fRead);
        }

        [TestMethod]
        [ExpectedException(typeof(ExeptionParseTree))]
        public void ExeptionTest()
        {
            StreamWriter fWrite = fInfo.CreateText();
            fWrite.WriteLine("( a )");
            fWrite.Close();
            
            fRead = fInfo.OpenText();
            ParseTree tree = new ParseTree(fRead);
        }

        [TestMethod]
        public void ResultTest()
        {
            StreamWriter fWrite = fInfo.CreateText();
            fWrite.WriteLine("( + 1 2 )");
            fWrite.Close();
         
            fRead = fInfo.OpenText();
            ParseTree tree = new ParseTree(fRead);
            Assert.IsTrue(tree.Result() == 3);
        }

        [TestCleanup]
        public void Clean()
        {
            fRead.Close();
            fInfo.Delete();
        }

        private FileInfo fInfo;
        private StreamReader fRead; 
    }
}
