
namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing Objects
        //initalize your testing objects here

        //Testing objects
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        /*[TestMethod]
        public void TestMethod()
        {
            //TODO: Task 4: remove this method before you create your first test method 
        }*/

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsFalse(job1.Id == job2.Id, "Id values for separate objects should not be equal");
            Assert.IsTrue(job1.Id < job2.Id, "Id values should increment as jobs are added");
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job3.Name, "Constructor correctly sets name field");
            Assert.AreEqual("ACME", job3.EmployerName.ToString(), "Constructor correctly sets employerName field");
            Assert.AreEqual("Desert", job3.EmployerLocation.ToString(), "Constructor correctly sets employerLocation field");
            Assert.AreEqual("Quality control", job3.JobType.ToString(), "Constructor correctly sets jobType field");
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.ToString(), "Constructor correctly sets jobCoreCompetency field");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.AreEqual(false, job3.Equals(job4), "Two jobs are not equal despite all other fields being equal, if only for ID");
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Assert.IsTrue(job3.ToString().StartsWith(Environment.NewLine));
            Assert.IsTrue(job3.ToString().EndsWith(Environment.NewLine));
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            Assert.AreEqual(job3.ToString(),
                Environment.NewLine + $"ID: {job3.Id}" +
                Environment.NewLine + $"Name: {job3.Name}" +
                Environment.NewLine + $"Employer: {job3.EmployerName}" +
                Environment.NewLine + $"Location: {job3.EmployerLocation}" +
                Environment.NewLine + $"Position Type: {job3.JobType}" +
                Environment.NewLine + $"Core Competency: {job3.JobCoreCompetency}" +
                Environment.NewLine);
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            job3.Name = "";

            Assert.AreEqual(job3.ToString(),
                Environment.NewLine + $"ID: {job3.Id}" +
                Environment.NewLine + $"Name: Data not available" +
                Environment.NewLine + $"Employer: {job3.EmployerName}" +
                Environment.NewLine + $"Location: {job3.EmployerLocation}" +
                Environment.NewLine + $"Position Type: {job3.JobType}" +
                Environment.NewLine + $"Core Competency: {job3.JobCoreCompetency}" +
                Environment.NewLine);
        }
    }
}

