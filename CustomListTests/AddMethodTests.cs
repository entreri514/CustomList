using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class AddMethodTests
    {
        [TestMethod]

        public void AddMethod_CountAsItemsAdded_CountIncrementsAsItemsAdded()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]

        public void AddMethod_AddOneItem_FirstItemAtIndexZero()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            //Act

            myList.Add("Hello");

            //Assert
            Assert.AreEqual("Hello", myList[0]);
        }              

        [TestMethod]
        public void AddMethod_AddTwoItems_SecondItemAtIndexOne()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            //Act
            myList.Add("Hello");
            myList.Add("world");

            //Assert
            Assert.AreEqual("world", myList[1]);
        }

        [TestMethod]

        public void AddMethod_CapacityIncreaseWhenExceeded_CapacityIncreased()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]

        public void AddMethod_AfterCapacityIncreases_OriginalItemInOriginalIndex()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}