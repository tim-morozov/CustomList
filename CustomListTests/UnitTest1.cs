using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_AddedValueGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 10;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_CountOfCustomListIncrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 1;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        // what happens if you add multiple things (or add to a CustomList that already has some values)?
        [TestMethod]
        public void Add_AddingValueToListThatAlreadyHasValues()
        { 
            CustomList<int> testList = new CustomList<int>();
            int addedItem = 10;
            int itemToAdd = 20;
            int itemToAdd1 = 40;
            int expected = 20;
            int actual;

            testList.Add(addedItem);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd1);
            actual = testList[1];

            Assert.AreEqual(expected, actual);
        }
        // what happens to the last-added item?
        [TestMethod]
        public void Add_LocationOfLastAddedItem()
        {
            CustomList<int> testList = new CustomList<int>();
            int firstAdded = 10;
            int lastAdded = 20;
            int expected = 2;
            int actual;

            testList.Add(firstAdded);
            testList.Add(lastAdded);
            actual = testList.Count;

            Assert.AreEqual(expected, actual);
            
        }
        // what happens to the Count?
        

        // what happens if you add more items than the initial Capacity of the CustomList?
       [TestMethod]
        public void Add_WhenCapacityIsReached_CapacityIncreases()
        {
            CustomList<int> testList = new CustomList<int>();
            testList.Capacity = 4;
            int actual;
            int expected = 8;

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            actual = testList.Capacity;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_WhenItemRemoved_CountDecrements()
        {
            CustomList<int> testList = new CustomList<int>();
            int actual;
            int expected;
        }
    }
}

