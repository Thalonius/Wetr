using System;
using DAL.Dao;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL.Common;
using DAL.Domain;
using System.Data.Common;
using System.Collections.Generic;

namespace Wetr.Test
{
    [TestClass]
    public class WetrTest
    {
        [TestMethod]
        public IConnectionFactory CreateConnection()
        {
            IConnectionFactory connectionFactory = IConnectionFactory.CreateConnection();
            Assert.AreNotEqual(null, connectionFactory);
            return connectionFactory;
        }

        [TestMethod]
        public IEnumerable<Community> FindAll()
        {
           
        }
    }
}
