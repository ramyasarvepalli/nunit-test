using NUnit.Framework;
using NUnitDemo;

namespace StudentGrades.nUnitTests
{
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
        [TestCase(97)]
        [TestCase(93)]
        [TestCase(96)]
        [TestCase(99)]
        public void GetGradeByPercentage_EqualTestCases(int percentage)
        {
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);
            Assert.That(grade, Is.EqualTo("A+"));
        }

        [TestCase(1)]
        [TestCase(32)]
        [TestCase(44)]
        [TestCase(55)]
        [TestCase(80)]
        public void GetGradeByPercentage_NotEqualTestCases(int percentage)
        {
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);
            Assert.That(grade, Is.Not.EqualTo("A+"));
        }

    }
}