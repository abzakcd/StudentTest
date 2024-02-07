using Student;

namespace StudentTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetAverage()
        {
            // AAA

            //A
            MyStudent st1 = new MyStudent(1234, "Dina", 2, new int[] { 91, 92 }, 2);
            MyStudent st2 = new MyStudent(4321, "Uri", 2, new int[] { 90, 92 }, 2);
            Assert.IsTrue(st1.GetAverage() > st2.GetAverage());
        }

        [TestMethod]
        public void TestClassification()
        {
            MyStudent st1 = new MyStudent(1234, "Dina", 2, new int[] { 91, 92 }, 2);
            string classificationExpected = "A";
            Assert.AreEqual(classificationExpected, st1.GetClassification());
        }
        [DataRow(1122, "Avsha", 2, new int[] { 56, 57 }, 2, "D")]
        [DataRow(1122,"Ayala",2,new int[] {96,97},2,"A")]
        [DataRow(1122, "Zion", 2, new int[] { 81, 50 }, 2, "F")]
        [DataRow(1122, "Nati", 2, new int[] { 81, 79 }, 2, "C")]
        [TestMethod]
        public void TestClassificationMoreStudents(int id,string name, int year, int[]grades,int courseNumber, string expectedOutput)
        {
            MyStudent st1 = new MyStudent(id, name, year, grades, courseNumber);
            
            Assert.AreEqual(expectedOutput, st1.GetClassification());
        }
    }
}