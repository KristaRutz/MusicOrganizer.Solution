using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests
{
    [TestClass]
    public class RecordTests : IDisposable
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

        [TestMethod]
        public void UpdateName_UpdatesName_String()
        {
            //Arrange
            string name = "Revolver";

            //Act
            string newRecordName = "Helplessness Blues";
            Record newRecord = new Record(name);
            newRecord.Name = newRecordName;
            string result = newRecord.Name;

            //Assert
            Assert.AreEqual(newRecordName, result);
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyList_RecordList()
        {
            // Arrange
            List<Record> newList = new List<Record> { };

            // Act
            List<Record> result = Record.GetAll();

            // Assert
            CollectionAssert.AreEqual(newList, result);
        }
    }
}