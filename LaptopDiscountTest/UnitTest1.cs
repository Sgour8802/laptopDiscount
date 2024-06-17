namespace LaptopDiscountTest;
using global::Midterm_Exam;
using Midterm_Exam;


[TestFixture]
public class EmployeeDiscountTests
{

    // Test case for calculate discount price for part time employee with no discount 
    [Test]
    public void Test_Calculate_DiscountedPrice_PartTimeEmployee_WithNoDiscount()
    {
        // Assign
        var employeeDiscountObj = new EmployeeDiscount
        {
            EmployeeType = EmployeeType.PartTime,
            Price = 100m
        };

        // Act
        var discountedPrice = employeeDiscountObj.CalculateDiscountedPrice();

        // Assert
        Assert.AreEqual(100m, discountedPrice);
    }

    // Test case for calculate discount price for part time employee with 5% discount 

    [Test]
    public void Test_Calculate_DiscountedPrice_PartialLoadEmployee_5PercentDiscount()
    {
        // Arrange
        var employeeDiscountObj = new EmployeeDiscount
        {
            EmployeeType = EmployeeType.PartialLoad,
            Price = 100m
        };

        // Act
        var discountedPrice = employeeDiscountObj.CalculateDiscountedPrice();

        // Assert
        Assert.AreEqual(95m, discountedPrice);
    }


    // Test case for calculate discount price for part time employee with 10% discount 

    [Test]
    public void Test_CalculateDiscount_Price_FullTimeEmployee_10PercentDiscount()
    {
        // Arrange
        var employeeDiscountObj = new EmployeeDiscount
        {
            EmployeeType = EmployeeType.FullTime,
            Price = 100m
        };

        // Act
        var discountedPrice = employeeDiscountObj.CalculateDiscountedPrice();

        // Assert
        Assert.AreEqual(90m, discountedPrice);
    }

    // Test case for calculate discount price for part time employee with 20% discount 
    [Test]
    public void Test_Calculate_DiscountedPrice_CompanyPurchasingEmployee_With20PercentDiscount()
    {
        // Arrange
        var employeeDiscountObj = new EmployeeDiscount
        {
            EmployeeType = EmployeeType.CompanyPurchasing,
            Price = 100m
        };

        // Act
        var discountedPrice = employeeDiscountObj.CalculateDiscountedPrice();

        // Assert
        Assert.AreEqual(80m, discountedPrice);
    }
}
