using ExceptionPracticeProblem;

namespace PersonTestCase
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void GetAgeCategory_ChildrenCategory()
        {
            // Arrange
            var person = new Person { Age = 10 };

            // Act
            var ageCategory = person.GetAgeCategory();

            // Assert
            Assert.AreEqual("Children", ageCategory);
        }

        [TestMethod]
        public void GetAgeCategory_YouthCategory()
        {
            // Arrange
            var person = new Person { Age = 20 };

            // Act
            var ageCategory = person.GetAgeCategory();

            // Assert
            Assert.AreEqual("Youth", ageCategory);
        }

        [TestMethod]
        public void GetAgeCategory_AdultsCategory()
        {
            // Arrange
            var person = new Person { Age = 30 };

            // Act
            var ageCategory = person.GetAgeCategory();

            // Assert
            Assert.AreEqual("Adults", ageCategory);
        }

        [TestMethod]
        public void GetAgeCategory_SeniorsCategory()
        {
            // Arrange
            var person = new Person { Age = 70 };

            // Act
            var ageCategory = person.GetAgeCategory();

            // Assert
            Assert.AreEqual("Seniors", ageCategory);
        }

        [TestMethod]
        public void GetAgeCategory_InvalidAgeException_NegativeAge()
        {
            // Arrange
            var person = new Person();

            // Act and Assert
            Assert.ThrowsException<InvalidAgeException>(() => person.Age = -5);
        }

        //[TestMethod]
        //public void GetAgeCategory_InvalidAgeException_NullAge()
        //{
        //    // Arrange
        //    var person = new Person();

        //    // Act and Assert
        //    Assert.ThrowsException<InvalidAgeException>(() => person.Age = null);
        //}

        //[TestMethod]
        //public void GetAgeCategory_InvalidAgeException_EmptyAge()
        //{
        //    // Arrange
        //    var person = new Person();

        //    // Act and Assert
        //    Assert.ThrowsException<InvalidAgeException>(() => person.Age = 0);
        //}

        [TestMethod]
        public void GetAgeCategory_InvalidAgeException_InvalidFormat()
        {
            // Arrange
            var person = new Person();

            // Act and Assert
            Assert.ThrowsException<FormatException>(() => person.Age = Convert.ToInt32("abc"));
        }
    }
}