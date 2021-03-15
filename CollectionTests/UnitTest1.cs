using NUnit.Framework;
using MyCollection;

namespace Tests
{
    public class Tests
    {
        MyColl<int> myColl = new MyColl<int>();
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Add()
        {
            // MyColl<int> myColl = new MyColl<int>();
            myColl.Add(3);
            Assert.AreEqual(3, myColl.GetByIndex(0));
        }

        [Test]
        public void AddByIndex()
        {
           // MyColl<int> myColl = new MyColl<int>();
            myColl.AddByIndex(3, 215);
            Assert.AreEqual(215, myColl.GetByIndex(3));
        }

    }
}