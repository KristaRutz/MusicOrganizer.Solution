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
    }
}