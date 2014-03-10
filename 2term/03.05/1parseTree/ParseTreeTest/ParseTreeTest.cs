using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.IO;

namespace NParseTreeTest
{
    using _1parseTree;

    [TestClass]
    public class ParseTreeTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            FileInfo fInfo = new FileInfo("..//..//newFile.txt");
            StreamWriter fWrite = fInfo.CreateText();
            fWrite.WriteLine("( + 1 2 )");
            fWrite.Close();
            StreamReader fRead = fInfo.OpenText();
            ParseTree tree = new ParseTree(fRead);
            fRead.Close();
            fInfo.Delete();
        }

        [TestMethod]
        public void ExeptionTest()
        {
            FileInfo fInfo = new FileInfo("..//..//newFile.txt");
            StreamWriter fWrite = fInfo.CreateText();
            fWrite.WriteLine("( a )");
            fWrite.Close();
            StreamReader fRead = fInfo.OpenText();
            try
            {
                ParseTree tree = new ParseTree(fRead);
            }
            catch (ExeptionParseTree)
            {
                Assert.IsTrue(true);
                return;
            }
            finally
            {
                fRead.Close();
                fInfo.Delete();
            }
            Assert.IsFalse(true);
        }

        [TestMethod]
        public void ResultTest()
        {
            FileInfo fInfo = new FileInfo("..//..//newFile.txt");
            StreamWriter fWrite = fInfo.CreateText();
            fWrite.WriteLine("( + 1 ( - 2 1 ) )");
            fWrite.Close();
            StreamReader fRead = fInfo.OpenText();
            ParseTree tree = new ParseTree(fRead);
            Assert.AreEqual(tree.Result(), 2);
            fRead.Close();
            fInfo.Delete();
        }
    }
}
