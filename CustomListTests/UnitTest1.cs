using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
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
            int item1 = 10;
            int item2 = 20;
            int item3 = 30;
            int expected = 2;
            int actual;

            testList.Add(item1);
            testList.Add(item2);
            testList.Add(item3);
            testList.Remove(item3);
            actual = testList.Count;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_WhenFirstItemRemoved_NextItemIsIndex0()
        {
            CustomList<int> testList = new CustomList<int>();
            int item1 = 10;
            int item2 = 20;
            int item3 = 30;
            int expected = 20;
            int actual;

            testList.Add(item1);
            testList.Add(item2);
            testList.Add(item3);
            testList.Remove(item1);
            actual = testList[0];

            Assert.AreEqual(expected, actual);
        }
         
        [TestMethod]
        public void Remove_WhenSeveralItemsRemoved_CountDecrements()
        {
            CustomList<int> testList = new CustomList<int>();
            int item1 = 10;
            int item2 = 20;
            int item3 = 30;
            int expected = 1;
            int actual;

            testList.Add(item1);
            testList.Add(item2);
            testList.Add(item3);
            testList.Remove(item3);
            testList.Remove(item2);
            actual = testList.Count;

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Remove_WhenMultipleRemoved_CapacityStaysTheSame()
        {
            CustomList<int> testList = new CustomList<int>();
            int actual;
            int expected = 8;

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Remove(5);
            testList.Remove(4);
            testList.Remove(3);
            testList.Remove(2);
            actual = testList.Capacity;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_WhenAllItemsRemoved_CountIsZero()
        {

            CustomList<int> testList = new CustomList<int>();
            int item1 = 10;
            int expected = 0;
            int actual;

            testList.Add(item1);
            testList.Remove(item1);
            actual = testList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_WhenSomethingIsNotInList_IndexDoesntChange()
        {
            CustomList<int> testList = new CustomList<int>();
            int item1 = 10;
            int item2 = 20;
            int item3 = 30;
            int expected = 10;
            int actual;

            testList.Add(item1);
            testList.Add(item2);
            testList.Add(item3);
            testList.Remove(item3);
            testList.Remove(item2);
            testList.Remove(50);
            actual = testList[0];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_WhenSomethingIsNotInList_CountDoesntChange()
        {
            CustomList<int> testList = new CustomList<int>();
            int item1 = 10;
            int item2 = 20;
            int item3 = 30;
            int expected = 1;
            int actual;

            testList.Add(item1);
            testList.Add(item2);
            testList.Add(item3);
            testList.Remove(item3);
            testList.Remove(item2);
            testList.Remove(50);
            actual = testList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_TurnsElementIntoAString()
        {
            CustomList<int> testList = new CustomList<int>();
            int item1 = 10;
            string expected = "10";
            string actual;

            testList.Add(item1);
            actual = testList.ToString();

            Assert.AreEqual(expected, actual);
        }

    }
}

