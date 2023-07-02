using BrewMachina.PractInventoryManagement.Domain.General;
using BrewMachina.PractInventoryManagement.Domain.ProductManagement;

namespace BMInventory.Tests;

public class ProductTests
{
    [Fact]
    public void UseProduct_Reduces_AmountInStock()
    {
        // Arrange
        Product product = new Product(99, "Test Coffee", "Test Description",
            new Price() { ItemPrice = 99, Currency = Currency.Aud }, UnitType.PerItem, 30);
        
        product.IncreaseStock(30);
        
        // Act
        product.UseProduct(20);
        
        // Assert
        Assert.Equal(10, product.AmountInStock);
    }

    [Fact]
    public void UseProduct_ItemsHigherThanStock_NoChangeToStock()
    {
        // Arrange
        Product product = new Product(100, "Test Coffee 2", "Test Description 2",
            new Price() { ItemPrice = 99, Currency = Currency.Aud }, UnitType.PerItem, 50);
        
        product.IncreaseStock(10);
        
        // Act
        product.UseProduct(100);
        
        // Assert
        Assert.Equal(10, product.AmountInStock);
    }
    
    [Fact]
    public void UseProduct_Reduces_AmountInStock_StockBelowThreshold()
    {
        // Arrange
        Product product = new Product(101, "Test Coffee 3", "Test Description 3",
            new Price() { ItemPrice = 99, Currency = Currency.Aud }, UnitType.PerItem, 50);

        int itemStock = 50;
        product.IncreaseStock(itemStock);
        
        // Act
        product.UseProduct(itemStock - 1);
        
        // Assert
        Assert.True(product.IsBelowStockThreshold);
    }
}