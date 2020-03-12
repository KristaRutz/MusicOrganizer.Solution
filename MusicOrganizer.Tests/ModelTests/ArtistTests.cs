using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests
{
    [TestClass]
    public class Test : IDisposable
    {
        public void Dispose()
        {
            Artist.ClearAll();
        }

        [TestMethod]
        public void ArtistConstructor_CreatesInstanceOfArtist_Artist()
        {
            Artist newArtist = new Artist("Blue Swede");
            Assert.AreEqual(typeof(Artist), newArtist.GetType());
        }

        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            //Arrange
            string name = "Amy Winehouse";
            Artist newArtist = new Artist(name);

            //Act
            string result = newArtist.Name;

            //Assert
            Assert.AreEqual(name, result);
        }

        [TestMethod]
        public void GetId_ReturnsArtistId_Int()
        {
            //Arrange
            string name = "The Beatles";
            Artist newArtist = new Artist(name);

            //Act
            int result = newArtist.Id;

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetAll_ReturnsAllArtistObjects_ArtistList()
        {
            //Arrange
            string name01 = "Etta James";
            string name02 = "Drake";
            Artist newArtist1 = new Artist(name01);
            Artist newArtist2 = new Artist(name02);
            List<Artist> newList = new List<Artist> { newArtist1, newArtist2 };

            //Act
            List<Artist> result = Artist.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void Find_ReturnsCorrectArtist_Artist()
        {
            //Arrange
            string name01 = "Bon Iver";
            string name02 = "Bruno Mars";
            Artist newArtist1 = new Artist(name01);
            Artist newArtist2 = new Artist(name02);

            //Act
            Artist result = Artist.FindById(2);

            //Assert
            Assert.AreEqual(newArtist2, result);
        }
    }
}