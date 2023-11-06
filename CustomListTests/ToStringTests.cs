using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class ToStringTests
    {
        [TestMethod]

        public void ToStringMethod_ListOfStrings_ReturnsListOfStrings()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string myString = "";
            //Act
            myList.Add("the");            
            myList.Add("quick");
            myList.Add("brown");
            myList.Add("fox");
            
            myString=myList.ToString();
            
            //Assert
            Assert.AreEqual(myString, ",the,quick,brown,fox");

        }

        [TestMethod]

        public void ToStringMethod_ListOfInts_ReturnsListOfStrings()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            string myString = "";

            //Act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myString = myList.ToString();

            //Assert
            Assert.AreEqual(myString, ",1,2,3");
        }
        [TestMethod]

        public void ToStringMethod_ListOfNull_ReturnsListOfNull()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string myString = "";
            //Act
            myList.Add("");
            myList.Add("");
            myList.Add("");
            myString = myList.ToString();
            //Assert
            Assert.AreEqual(myString, ",,,");




        }

        





    }
}
