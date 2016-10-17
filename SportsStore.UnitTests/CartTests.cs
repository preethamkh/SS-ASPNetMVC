using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportsStore.Domain.Entities;

namespace SportsStore.UnitTests
{
    [TestClass]
    public class CartTests
    {
        [TestMethod]
        public void Can_Add_New_Lines()
        {
            // Arrange = create some test products
            Product p1 = new Product { ProductID = 1, Name = "P1"};
            Product p2 = new Product { ProductID = 2, Name = "P2" };
            Product p3 = new Product { ProductID = 3, Name = "P3" };
            Product p4 = new Product { ProductID = 4, Name = "P4", Price = 100M };
            Product p5 = new Product { ProductID = 5, Name = "P5", Price = 50M };

            // Arrange - create a new cart
            Cart target = new Cart();

            // Act
            target.AddItem(p1, 1);
            target.AddItem(p2, 3);
            target.AddItem(p3, 5);
            target.AddItem(p2, 1);
            // CartLine[] results = target.Lines.ToArray();\
            CartLine[] results = target.Lines.OrderBy(c => c.Product.ProductID).ToArray();
            target.RemoveLine(p2);

            target.AddItem(p4, 1);
            target.AddItem(p5, 1);
            target.AddItem(p4, 3);
            decimal result = target.ComputeTotalValue();
            target.Clear();


            // Assert
            //Assert.AreEqual(results.Length, 2);
            //Assert.AreEqual(results[0].Product, p1);
            //Assert.AreEqual(results[1].Product, p2);
            //Assert.AreEqual(results[0].Quantity, 11);
            //Assert.AreEqual(results[1].Quantity, 1);
            //Assert.AreEqual(target.Lines.Count(c => c.Product == p2), 0);
            //Assert.AreEqual(target.Lines.Count(), 2);
            //Assert.AreEqual(result, 450M);
            Assert.AreEqual(target.Lines.Count(), 0);
        }
    }
}
