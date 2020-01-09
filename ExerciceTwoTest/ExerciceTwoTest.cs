using Microsoft.VisualStudio.TestTools.UnitTesting;
using CandidateTesting.RenanRossinideOlivera.AgileExercices.Class;

namespace ExerciceTwoTest
{
    [TestClass]
    public class ExerciceTwoTest
    {
        [TestMethod]
        public void CommandAnalyseAndFileCreationTest()
        {
            
            // Arrange
            string input = "convert https://s3.amazonaws.com/uux-itaas-static/minha-cdn-logs/input-01.txt ./output/minhaCdn1.txt";
            string expectedOutput = "success";
            // Act
            var actualOutput = FileCreation.CommandAnalyse(input);
            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);

        }
    }
}
