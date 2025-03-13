> Create a class library for test project
> Install NUnit latest version
> Install Nunit 3 test adapter latest version
or
> Add new NUnit test project

> Build the complete solution to explore tests in Test Explorer
> Run the tests in Test Explorer


NUnit testing process:
> Arrange: Set up the test data and preconditions for the test method
> Act: Invoke the method under test with the arranged parameters
> Assert: Verify that the method under test behaves as expected

NUnit Attributes:
Important Attributes:
> Setup: Method that is run before each test method
> TestFixture: A class that contains test methods
> Test: A method that contains test code
> TestCase: A method that contains test code with multiple test cases

> TearDown: Method that is run after each test method
> OneTimeSetUp: Method that is run once before any test methods
> OneTimeTearDown: Method that is run once after all test methods
> Category: A way to categorize tests
> Ignore: Ignore a test method
> Description: A description of the test method
> MaxTime: Maximum time in milliseconds for a test method to run
> Timeout: Maximum time in milliseconds for a test method to run
> Repeat: Number of times to repeat a test method
> Retry: Number of times to retry a test method if it fails

> For example test class file, refer GradeCalculatorTest.cs

public class GradeCalculatorTests
    {
        private GradeCalculator _gradeCalculator { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
            _gradeCalculator = new GradeCalculator();
        }

        [Test]
        public void GetGradeByPercentage_EqualTest()
        {
            // Assign
            int percentage = 99;

            // Act
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);

            // Assert
            Assert.That(grade, Is.EqualTo("A+"));
        }

        [TestCase(90)]
        [TestCase(91)]
        [TestCase(93)]
        [TestCase(96)]
        [TestCase(99)]
        public void GetGradeByPercentage_EqualTestCases(int percentage)
        {
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);
            Assert.That(grade, Is.EqualTo("A+"));
        }
        }
	