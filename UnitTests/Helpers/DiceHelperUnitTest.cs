using Mine.Models;
using NUnit.Framework;
using Mine.Helpers;

namespace UnitTests.Helpers
{
    [TestFixture]
    public class DiceHelperTests
    {
        /// <summary>
        /// check for invalid rol zero
        /// </summary>
        [Test]
        public void RollDice_Invalid_Roll_Zero_Should_Return_Zero()
        {
            // Arrange

            // Act
            var result = DiceHelper.RollDice(0, 1);

            // Reset

            // Assert 
            Assert.AreEqual(0, result);
        }


        /// <summary>
        /// Cheeck for rolling 1 dice 6
        /// </summary>
        [Test]
        public void RollDice_Valid_Roll_1_Dice_6_Should_Return_Between_1_and_6()
        {
            //Arrange

            //Act
            var result = DiceHelper.RollDice(1, 6);

            //Reset

            //Assert
            Assert.AreEqual(true, result >= 1);
            Assert.AreEqual(true, result <= 6);

        }

        /// <summary>
        /// Test for forcing 1 should return 1
        /// </summary>
        [Test]
        public void RollDice_Invalid_Roll_Forced_1_Should_Return_1()
        {
            //Arrange
            DiceHelper.ForceRollsToNotRandom = true;
            DiceHelper.ForcedRandomValue = 1;

            //Act
            var result = DiceHelper.RollDice(1, 1);

            //Reset
            DiceHelper.ForceRollsToNotRandom = false;

            //Assert
            Assert.AreEqual(1, result);
        }

        /// <summary>
        /// test for RollDice(2,6)
        /// </summary>
        [Test]
        public void RollDice_Valid_Roll_2_Dice_6_Should_Return_Between_2_and_12()
        {
            //Arrange

            //Act
            var result = DiceHelper.RollDice(2, 6);

            //Reset

            //Assert
            Assert.AreEqual(true, result >= 2);
            Assert.AreEqual(true, result <= 12);

        }

        /// <summary>
        /// Test for Invalid RollDice(0,10)
        /// </summary>
        [Test]
        public void RollDice_InValid_Roll_0_Dice_10_Should_Return_Zero()
        {
            //Arrange

            //Act
            var result = DiceHelper.RollDice(0,10);

            //Reset

            //Assert
            Assert.AreEqual(true, result == 0);
        }

        /// <summary>
        /// Test for Invalid RollDice(1,0)
        /// </summary>
        [Test]
        public void RollDice_InValid_Roll_1_Dice_0_Should_Return_Zero()
        {
            //Arrange

            //Act
            var result = DiceHelper.RollDice(1,0);

            //Reset

            //Assert
            Assert.AreEqual(true, result == 0);

        }

        /// <summary>
        /// Test for RollDice(1,10) with 5 as fixed value
        /// </summary>
        [Test]
        public void RollDice_Valid_Roll_1_Dice_10_Fixed_5_Should_Return_5()
        {
            //Arrange
            DiceHelper.ForceRollsToNotRandom = true;
            DiceHelper.ForcedRandomValue = 5;

            //Act
            var result = DiceHelper.RollDice(1, 10);

            //Reset
            DiceHelper.ForceRollsToNotRandom = false;

            //Assert
            Assert.AreEqual(5, result);

        }


    }
}
