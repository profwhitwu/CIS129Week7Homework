namespace Week7Homework_Methods_Tests
{
    [TestClass]
    public class MethodsHomework_Tests
    {
        public MethodsHomework methodsHomework;
        public List<Person> people;

        [TestInitialize]
        public void Setup()
        {
            methodsHomework = new MethodsHomework();
            people = new List<Person>()
            {
                new Person()
                {
                    FirstName = "Carl",
                    LastName = "Jr",
                    HasIncome = true,
                    Age = 20,
                    IsDependent = false
                },
                new Person()
                {
                    FirstName = "Ron",
                    LastName = "McDon",
                    HasIncome = true,
                    Age = 17,
                    IsDependent = true
                },
                new Person()
                {
                    FirstName = "Dale",
                    LastName = "Gribble",
                    HasIncome = false,
                    Age = 44,
                    IsDependent = false
                },
                new Person()
                {
                    FirstName = "Son",
                    LastName = "Goku",
                    HasIncome = true,
                    Age = 48,
                    IsDependent = true
                },
            };
        }

        [TestMethod]
        public void ConvertToNearestWhole_Gives5And6Tenths_Returns6()
        {
            // arrange
            decimal number = 5.6m;

            // act
            var result = methodsHomework.ConvertToNearestWhole(number);

            // assert

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void ConvertToNearestWhole_Gives5And4Tenths_Returns6()
        {
            // arrange
            decimal number = 5.4m;

            // act
            var result = methodsHomework.ConvertToNearestWhole(number);

            // assert

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void ConvertToNearestWhole_Gives5And5Tenths_Returns6()
        {
            // arrange
            decimal number = 5.5m;

            // act
            var result = methodsHomework.ConvertToNearestWhole(number);

            // assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void CombineStrings_ProvidesTwoStrings_ReturnsOneString()
        {
            // arrange
            string firstString = "Hello";
            string lastString = "There";

            // act
            var result = methodsHomework.CombineStrings(firstString, lastString);

            //assert
            Assert.AreEqual("HelloThere", result);
        }

        [TestMethod]
        public void CombineStrings_ProvidesThreeStrings_ReturnsOneString()
        {
            // arrange
            string firstString = "Hello";
            string secondString = "There";
            string finalString = "Kenobi";

            // act
            var result = methodsHomework.CombineStrings(firstString, secondString, finalString);

            //assert
            Assert.AreEqual("HelloThereKenobi", result);
        }

        [TestMethod]
        public void VowelCounter_Inserts3Vowels_Returns3()
        {
            // arrange
            string vowelString = "Alceo";

            // act
            int vowelCount = vowelString.VowelCounter();

            // assert
            Assert.AreEqual(3, vowelCount);
        }

        [TestMethod]
        public void VowelCounter_Inserts0Vowels_Returns0()
        {
            // arrange
            string vowelString = "bbbb";

            // act
            int vowelCount = vowelString.VowelCounter();

            // assert
            Assert.AreEqual(0, vowelCount);
        }

        [TestMethod]
        public void CheckTaxRefundEligibility_ProvidesListOfPersonObjects_AllButOneAreEligible()
        {
            // act
            methodsHomework.CheckTaxRefundEligibility(people);

            // assert
            Assert.IsTrue(people.Where(x => x.IsEligibleForRefund == true).Count() == 1);
            Assert.IsTrue(people.Where(x => x.IsEligibleForRefund == false).Count() == 3);
        }

        [TestMethod]
        public void IsIntEven_IntIsEven_ReturnsTrue()
        {
            // arrange
            int myint = 6;

            // act
            var result = myint.IsIntEven();

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsIntEven_IntIsOdd_ReturnsFalse()
        {
            // arrange
            int myint = 7;

            // act
            var result = myint.IsIntEven();

            // assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CalculateIncomeTaxes_OptionalParamNotUsed_ReturnsCalcWithNoAddtionalTaxesWithheld()
        {
            // arrange
            decimal taxesToWithold = .2m;
            decimal income = 100m;

            // act
            var result = methodsHomework.CalculateIncomeTaxes(income, taxesToWithold);

            // assert
            Assert.AreEqual((decimal)20m, result);
        }

        [TestMethod]
        public void CalculateIncomeTaxes_OptionalParamUsed_ReturnsCalcWitAddtionalTaxesWithheld()
        {
            // arrange
            decimal taxesToWithold = .2m;
            decimal addtionalTaxes = .1m;
            decimal income = 100m;

            // act
            var result = methodsHomework.CalculateIncomeTaxes(income, taxesToWithold, addtionalTaxes);

            // assert
            Assert.AreEqual((decimal)30m, result);
        }
    }
}