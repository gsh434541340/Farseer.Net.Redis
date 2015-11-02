using System;
using System.Collections.Generic;
using System.Diagnostics;
using FS.Redis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Farseer.Net.NoSql.Tests
{
    [TestClass]
    public class KeyTest
    {
        private readonly RedisContext _db = new RedisContext("192.168.1.2");

        [TestMethod]
        public void GetAllKeyTest()
        {
            _db.Key.GetKeys();
        }

        [TestMethod]
        public void IsExistsKeyTest()
        {
            var allKey = _db.Key.GetKeys();
            Assert.IsTrue(_db.Key.ContainsKey(allKey[0]));
            Assert.IsFalse(_db.Key.ContainsKey(allKey[0] + "ASDF"));
        }

        [TestMethod]
        public void RemoveKeyTest()
        {
            var allKey = _db.Key.GetKeys();
            var allCount = allKey.Count;

            _db.Key.RemoveKey(allKey[0]);
            var newCount = _db.Key.GetKeys().Count;

            Assert.IsTrue(allCount == ++newCount);
        }
    }
}