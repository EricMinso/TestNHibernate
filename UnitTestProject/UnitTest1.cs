using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// Our internal references
using DataModel;
using NHibernateDataAccess;
using System.Collections.Generic;


namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDataManangerInitialisation()
        {
            DataManager dataManager = DataManager.getInstance();
            Assert.IsNotNull( dataManager );
        }

        [TestMethod]
        public void TestDataReadingFromDB()
        {
            DataManager dataManager = DataManager.getInstance();
            Assert.IsNotNull( dataManager );

            IList<Person> personList = dataManager.getAllPersons();

            Assert.IsNotNull( personList );
            Assert.IsTrue( personList.Count > 0 );
        }
    }
}
