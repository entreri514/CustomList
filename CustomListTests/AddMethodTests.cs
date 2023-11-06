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
            CustomList<string> myList = new CustomList<string>();
           
            //Act
            myList.Add("hello");
            myList.Add("world");

            //Assert
            Assert.AreEqual(2, myList.count);
        }

        [TestMethod]

        public void AddMethod_AddOneItem_FirstItemAtIndexZero()
        {
            //Arrange               

            CustomList<string> myList = new CustomList<string>();
            //Act

            myList.Add("Hello");

            //Assert
            Assert.AreEqual("Hello", myList.items[0]);
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
            Assert.AreEqual("world", myList.items[1]);
        }

        [TestMethod]

        public void AddMethod_CapacityIncreaseWhenExceeded_CapacityIncreased()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("The");
            myList.Add("quick");
            myList.Add("brown");
            myList.Add("fox");
            myList.Add("jumped");
            myList.Add("over");
            myList.Add("the");
            myList.Add("dog");
            
            //Assert
            Assert.AreEqual(9, myList.capacity);
        }

        [TestMethod]

        public void AddMethod_AfterCapacityIncreases_OriginalItemInOriginalIndex()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("The");
            myList.Add("quick");
            myList.Add("brown");
            myList.Add("fox");
            myList.Add("jumped");
            myList.Add("over");
            myList.Add("the");
            myList.Add("dog");
      
            //Assert
            Assert.AreEqual("brown", myList.items[2]);
        }
    }
}