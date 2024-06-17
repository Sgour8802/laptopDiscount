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
        // Assign
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
        // Assign
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
        // Assign
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

    // Test case for calculate discount price for Full Time Employee_DifferentPrice
    [Test]
    public void Test_FullTimeEmployee_DifferentPrice()
    {
        var employeeDiscount = new EmployeeDiscount
        {
            EmployeeType = EmployeeType.FullTime,
            Price = 200m
        };

        var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

        Assert.AreEqual(180m, discountedPrice);
    }

    // Test cases for company purchasing Employee Different Price
    [Test]
    public void TestCase_Employee_DifferentPrice()
    {
        var employeeDiscount = new EmployeeDiscount
        {
            EmployeeType = EmployeeType.CompanyPurchasing,
            Price = 250m
        };

        var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

        Assert.AreEqual(200m, discountedPrice);
    }

}
