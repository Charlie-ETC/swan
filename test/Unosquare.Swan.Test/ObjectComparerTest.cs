﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Unosquare.Swan.Components;
using Unosquare.Swan.Test.Mocks;

namespace Unosquare.Swan.Test
{
    [TestFixture]
    public class ObjectComparerTest
    {
        [Test]
        public void CompareEqualsObjectsTest()
        {
            var left = DateBasicJson.GetDateDefault();
            var right = DateBasicJson.GetDateDefault();

            Assert.IsTrue(ObjectComparer.AreObjectsEqual(left, right));
        }

        [Test]
        public void CompareDifferentObjectsTest()
        {
            var left = BasicJson.GetDefault();
            var right = new BasicJson();

            Assert.IsFalse(ObjectComparer.AreObjectsEqual(left, right));
        }

        [Test]
        public void CompareEqualsStructsTest()
        {
            var left = new SampleStruct();
            var right = new SampleStruct();

            Assert.IsTrue(ObjectComparer.AreStructsEqual(left, right));
        }

        [Test]
        public void CompareDifferentStructsTest()
        {
            var left = new SampleStruct() { Name = "PEPE", Value = 1 };
            var right = new SampleStruct() { Name = "PEPE", Value = 2  };

            Assert.IsFalse(ObjectComparer.AreStructsEqual(left, right));
        }

        [Test]
        public void CompareEqualsArrayTest()
        {
            var first = new[] { 1, 2, 3 };
            var second = new[] { 1, 2, 3 };

            Assert.IsTrue(ObjectComparer.AreEnumsEqual(first, second));
        }

        [Test]
        public void CompareDifferentsArrayTest()
        {
            var first = new[] { 1, 2, 3 };
            var second = new[] { 1, 2, 4 };

            Assert.IsFalse(ObjectComparer.AreEnumsEqual(first, second));
        }

        [Test]
        public void CompareEqualObjectsWithArrayProperty()
        {
            var first = new AdvArrayJson { Id = 1, Properties = new[] { BasicJson.GetDefault() } };
            var second = new AdvArrayJson { Id = 1, Properties = new[] { BasicJson.GetDefault() } };

            Assert.IsTrue(ObjectComparer.AreEqual(first, second));
        }

        [Test]
        public void CompareEqualArrayWithObjects()
        {
            var first = new[] { BasicJson.GetDefault(), BasicJson.GetDefault() };
            var second = new[] { BasicJson.GetDefault(), BasicJson.GetDefault() };

            Assert.IsTrue(ObjectComparer.AreEnumsEqual(first, second));
        }
    }
}
