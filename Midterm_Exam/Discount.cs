using System;
namespace Midterm_Exam
{
    public enum EmployeeType
    {
        PartTime,       // No Discount
        PartialLoad,    // 5% Discount
        FullTime,       // 10% Discount
        CompanyPurchasing // 20% Discount
    }

    public class EmployeeDiscount
    {
        public EmployeeType EmployeeType { get; set; }
        public decimal Price { get; set; }
        public object Assert { get; set; }

        public decimal CalculateDiscountedPrice()
        {
            decimal discount = 0;

            switch (EmployeeType)
            {
                case EmployeeType.PartTime:
                    discount = 0; // No discount
                    break;
                case EmployeeType.PartialLoad:
                    discount = 0.05m; // 5% discount
                    break;
                case EmployeeType.FullTime:
                    discount = 0.10m; // 10% discount
                    break;
                case EmployeeType.CompanyPurchasing:
                    discount = 0.20m; // 20% discount
                    break;
            }

            return Price - (Price * discount);
        }
    }
}






//using System;
//using Xunit;

//namespace Midterm_Exam.Tests
//{
//    public class EmployeeDiscountTests
//    {
//        [Fact]
//        public void PartTimeEmployee_NoDiscount()
//        {
//            var employeeDiscount = new EmployeeDiscount
//            {
//                EmployeeType = EmployeeType.PartTime,
//                Price = 100m
//            };

//            var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

//            Assert.Equal(100m, discountedPrice);
//        }

//        [Fact]
//        public void PartialLoadEmployee_FivePercentDiscount()
//        {
//            var employeeDiscount = new EmployeeDiscount
//            {
//                EmployeeType = EmployeeType.PartialLoad,
//                Price = 100m
//            };

//            var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

//            Assert.Equal(95m, discountedPrice);
//        }

//        [Fact]
//        public void FullTimeEmployee_TenPercentDiscount()
//        {
//            var employeeDiscount = new EmployeeDiscount
//            {
//                EmployeeType = EmployeeType.FullTime,
//                Price = 100m
//            };

//            var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

//            Assert.Equal(90m, discountedPrice);
//        }

//        [Fact]
//        public void CompanyPurchasingEmployee_TwentyPercentDiscount()
//        {
//            var employeeDiscount = new EmployeeDiscount
//            {
//                EmployeeType = EmployeeType.CompanyPurchasing,
//                Price = 100m
//            };

//            var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

//            Assert.Equal(80m, discountedPrice);
//        }

//        [Fact]
//        public void FullTimeEmployee_DifferentPrice()
//        {
//            var employeeDiscount = new EmployeeDiscount
//            {
//                EmployeeType = EmployeeType.FullTime,
//                Price = 200m
//            };

//            var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

//            Assert.Equal(180m, discountedPrice);
//        }

//        [Fact]
//        public void CompanyPurchasingEmployee_DifferentPrice()
//        {
//            var employeeDiscount = new EmployeeDiscount
//            {
//                EmployeeType = EmployeeType.CompanyPurchasing,
//                Price = 250m
//            };

//            var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

//            Assert.Equal(200m, discountedPrice);
//        }
//    }
//}
