using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class SafetyDataTests
    {
        [TestMethod]
        public void IsCrimeDBCreated()
        {
            CrimeDB crimedb = null;
            Assert.AreEqual(null, crimedb);
            
            crimedb= new CrimeDB();
            Assert.AreNotEqual(null, crimedb);

        }
        [TestMethod]
        public void IsFirstResponderCreated()
        {
            FirstResponder responder = null;
            Assert.AreEqual(null, responder);

            responder = new FirstResponder();
            Assert.AreNotEqual(null, responder);

        }

        [TestMethod]
        public void IsIncidentCreated()
        {
            Incident incident = null;
            Assert.AreEqual(null, incident);

            incident = new Incident();
            Assert.AreNotEqual(null, incident);

        }
    }
}
