using NUnit.Framework;
using Moq;
using SchoolDataLibrary;

namespace SchoolDataLibrary
{
    [TestFixture]
    public class SchoolDataTests
    {
        [Test]
        public void TestTeacherSalary()
        {
            // Arrange
            var teacher = new Teacher();
            teacher.Salary = 50000;

            // Act
            var actualSalary = teacher.Salary;

            // Assert
            Assert.AreEqual(50000, actualSalary);
        }

        // Add more test methods for other classes and scenarios...

        [Test]
        public void TestSubjectDependency()
        {
            // Arrange
            var mockTeacher = new Mock<Teacher>();
            mockTeacher.Setup(t => t.GetSubject()).Returns("Math");
            var subject = new Subject(mockTeacher.Object);

            // Act
            var subjectTeacher = subject.GetTeacher();

            // Assert
            Assert.AreEqual("Math", subjectTeacher.GetSubject());
        }
    }
}


