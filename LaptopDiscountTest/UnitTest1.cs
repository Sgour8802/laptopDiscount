namespace LaptopDiscountTest;
using global::Midterm_Exam;
using Midterm_Exam;


[TestFixture]
public class EmployeeDiscountTests
{
    [Test]
    public void Test_CalculateDiscountedPrice_PartTimeEmployee_WithNoDiscount()
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

    [Test]
    public void Test_CalculateDiscountedPrice_PartialLoadEmployee_5PercentDiscount()
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

    [Test]
    public void Test_CalculateDiscountedPrice_FullTimeEmployee_10PercentDiscount()
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

    [Test]
    public void Test_CalculateDiscountedPrice_CompanyPurchasingEmployee_With20PercentDiscount()
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
