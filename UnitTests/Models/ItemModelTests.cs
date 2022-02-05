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
    }
}
