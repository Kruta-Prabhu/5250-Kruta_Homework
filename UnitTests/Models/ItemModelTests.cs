using Mine.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Models
{
    [TestFixture]
    public class ItemModelTests
    {
        /// <summary>
        /// Checking that ItemModel is not null
        /// </summary>
        [Test]
        public void ItemModel_Constructor_Valid_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ItemModel();

            // Reset

            // Assert 
            Assert.IsNotNull(result);
        }

        [Test]
        public void ItemModel_Set_Get_Valid_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ItemModel();
            result.Description = "Description";
            result.Id = "ID";
            result.Text = "Text";
            result.value = 1;

            // Reset

            // Assert 
            Assert.IsNotNull(result);
            Assert.AreEqual("Description", result.Description);
            Assert.AreEqual("ID", result.Id);
            Assert.AreEqual("Text", result.Text);
            Assert.AreEqual(1, result.value);
        }
    }
}
