using CommonTypes;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // works
            Person person = new Person() { Name = "Test" };

            // throws
            string xml = @"<Person><Name>John Doe</Name></Person>";
            Person personX = Person.DeserializeFromXml(xml);
            Console.WriteLine(personX.Name);
        }
    }
}