using NUnit.Framework;
using MyCollection;
using System;

namespace Tests
{
    public class Tests
    {
        DigitalLIst<int> dl = new DigitalLIst<int>();
        [Test]
        public void Add()
        {
            dl.Add(3);
            Assert.AreEqual(3, dl.GetByIndex(0));
        }

        [Test]
        public void AddByIndex()
        {
            dl.AddByIndex(3, 215);
            Assert.AreEqual(215, dl.GetByIndex(3));
        }
        [Test]
        public void Add1()
        {
            dl.Add(5);
            Assert.AreEqual(5, dl.GetByIndex(1));
        }
        [Test]
        public void Remove()
        {
            dl.AddByIndex(4, 2);
            dl.AddByIndex(5, 7);
            dl.Remove(2);
            Assert.AreEqual(7, dl.GetByIndex(4));
        }
        [Test]
        public void RemoveByIndex()
        {
            dl.AddByIndex(11, 95);
            dl.AddByIndex(12, 75);
            dl.RemoveByIndex(11);
            Assert.AreEqual(75, dl.GetByIndex(11));
        }
        [Test]
        public void MaxValue()
        {
            dl.AddByIndex(5, 7);
            dl.Add(8);
            dl.AddByIndex(2, 10);
            Assert.AreEqual(215, dl.MaxValue());
        }

        [Test]
        public void Exception()
        {
            Assert.Throws<Exception>(delegate() {DigitalLIst<string> dl1 = new DigitalLIst<string>(); });
        }
    }
}