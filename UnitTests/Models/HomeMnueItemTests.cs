using Mine.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Models
{
    [TestFixture]
    public class HomeMnueItemTests
    {
        /// <summary>
        /// Checking that ItemModel is not null
        /// </summary>
        [Test]
        public void HomeMenuItem_Constructor_Valid_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new HomeMenuItem();

            // Reset

            // Assert 
            Assert.IsNotNull(result);
        }

        [Test]
        public void HomeMenuItem_Set_Get_Valid_Default_Should_Pass()
        {
            // Arrange
           

            // Act
            var result = new HomeMenuItem();
            result.Id = MenuItemType.Items;
            result.Title = "Title";

            // Reset

            // Assert 
            Assert.IsNotNull(result);
            
            Assert.AreEqual(MenuItemType.Items, result.Id);
            Assert.AreEqual("Title", result.Title);
            
        }


    }
}
