using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;

namespace MusicOrganizer.Tests
{
    [TestClass]
    public class RecordTests
    {
        public void Dispose()
        {
            Record.ClearAll();
        }
        [TestMethod]
        public void RecordConstructor_CreatesInstanceOfRecord_Record()
        {
            Record newRecord = new Record("test");
            Assert.AreEqual(typeof(Record), newRecord.GetType());
        }

        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            //Arrange
            string name = "Revolver";

            //Act
            Record newRecord = new Record(name);
            string result = newRecord.Name;

            //Assert
            Assert.AreEqual(name, result);
        }
    }
}