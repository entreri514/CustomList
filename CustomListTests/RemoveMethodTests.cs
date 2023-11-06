using CustomList; 


namespace CustomListTests
{
    [TestClass]
    public class RemoveMethodTests
    {
        [TestMethod]
        
        public void RemoveMethod_CountAsItemRemoved_CountDecrementsAsItemsRemoved()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("hello");
            myList.Add("world");
            myList.Remove("hello");
            //Assert
            Assert.AreEqual(1, myList.count);
        }

        [TestMethod]

        public void RemoveMethod_TestForTrueAsItemRemoved_MethodReturnsTrueWhenItemRemoved()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("hello");
            myList.Add("world");
            bool didRemove = myList.Remove("hello");
          

            //Assert
            Assert.IsTrue(didRemove);

        }

        [TestMethod]

        public void RemoveMethod_AttemptRemoveItemNotInList_CountNotDecremented()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("hello");
            myList.Add("world");
            myList.Remove("dog");

            //Assert
            Assert.AreEqual(2, myList.count);

        }

        [TestMethod]    
    
        public void RemoveMethod_ItemsShiftBackwardWhenRemoved_RemovedItemIndexFilled()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("hello");
            myList.Add("world");
            myList.Remove("hello");

            //Assert
            Assert.AreEqual("world", myList.items[0]);

        }

        [TestMethod]

        public void RemoveMethod_WhenItemExistsMultipleTimes_OnlyFirstInstanceItemRemoved()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("hello");
            myList.Add("world");
            myList.Add("hello");
            myList.Remove("hello");

            //Assert
            Assert.AreEqual("world", myList.items[0]);

        }
    
    
    
    
    
    }



}
