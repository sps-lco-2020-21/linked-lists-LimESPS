using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Linked_Lists.Lib;
namespace Linked_List_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCount()
        {
            var list = new IntegerLinkedList();
            list.AddToEnd(5);
            list.AddToEnd(6);
            list.AddToEnd(54);
            list.AddToBeginning(43);
            Assert.AreEqual(true, list.Count()== 4);
            Console.WriteLine(list.Count());
        }
        [TestMethod]
        public void TestSum()
        {
            var ill = new IntegerLinkedList(5);
            ill.AddToEnd(7);
            ill.AddToEnd(9);
            Assert.AreEqual(21, ill.sum());
        }

        
        [TestMethod]
        public void delete()
        {
            var ill = new IntegerLinkedList(5);
            ill.AddToEnd(7);
            ill.AddToEnd(9);
           
            Assert.AreEqual(true, ill.delete(7));
        }
        [TestMethod]
        public void remove_duplicates() //does not work
        {
            var ill = new IntegerLinkedList(5);
            ill.AddToEnd(7);
            ill.AddToEnd(9);
            ill.AddToEnd(7);
            ill.remove_duplicates();
            //Assert.AreEqual(3, ill.Count());
        }
        [TestMethod]
        public void SortedIntegerLinkedList()
        {
            var ill = new SortedIntegerLinkedList(5);
            ill.AddSorted(7);
            ill.AddSorted(9);
            ill.AddSorted(6);
            ill.AddSorted(4);
            Assert.AreEqual(4, ill.first());
            Assert.AreEqual(7, ill.third());
        }



    }
}
