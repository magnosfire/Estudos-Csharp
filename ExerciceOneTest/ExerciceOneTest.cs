using Microsoft.VisualStudio.TestTools.UnitTesting;
using CandidateTesting.RenanRossinideOlivera.AgileExercices.Class;

namespace ExerciceOneTest
{
    [TestClass]
    public class ExerciceOneTest
    {
        [TestMethod]
        public void siblingAnalyseTest()
        {

            // Arrange
            string input = "213";
            long expectedOutput = 321;
            // Act
            var actualOutput = Siblings.siblingAnalyse(input);
            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);

        }
    }
}
