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
            
            //Act
            myList.Add("the");            
            myList.Add("quick");
            myList.Add("brown");
            myList.Add("fox");
            
            myList.ToString();
            
            //Assert
            Assert.AreEqual(myList, "thequickbrownfox");

        }







    }
}
