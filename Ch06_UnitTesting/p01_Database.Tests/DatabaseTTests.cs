namespace p01_Database.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class DatabaseTTests
    {
        private const string DBFullMsg = "Database is full!";
        private const string DBEmptyMsg = "Database is empty!";

        [Test]
        public void DatabaseRegistersElements()
        {
            DatabaseT<int> sut = new DatabaseT<int>(1, 2, 3, 4, 5);

            Assert.AreEqual(5, sut.Count, "Registered items count does not match!");
        }

        [Test]
        public void EmptyDatabaseHasZeroCount()
        {
            DatabaseT<int> sut = new DatabaseT<int>();

            Assert.AreEqual(0, sut.Count, "Database count is not zero when it should be!");
        }

        [Test]
        public void FullDatabaseThrowsExceptionWhenAddingMoreItems()
        {
            DatabaseT<int> sut = new DatabaseT<int>(Enumerable.Range(0, 16).ToArray());

            Exception ex = Assert.Throws<InvalidOperationException>(() => sut.Add(100));

            Assert.AreEqual(DBFullMsg, ex.Message);
        }

        [Test]
        public void InitializingDBOverCapacityThrowsException()
        {
            try
            {
                DatabaseT<int> sut = new DatabaseT<int>(Enumerable.Range(0, 17).ToArray());
            }
            catch (Exception ex)
            {
                Assert.AreEqual(DBFullMsg, ex.Message);
                return;
            }

            Assert.Fail();
        }

        [Test]
        public void RemoveLastItemFromDatabase()
        {
            DatabaseT<int> sut = new DatabaseT<int>(1, 2, 3);

            Assert.That(() => sut.Remove() == 3, "Removing last item from Database fails.");
        }

        [Test]
        public void RemovingItemChangesCount()
        {
            DatabaseT<int> sut = new DatabaseT<int>(1);

            sut.Remove();

            Assert.AreEqual(0, sut.Count);
        }

        [Test]
        public void RemovingItemFromEmptyDatabaseThrowsException()
        {
            DatabaseT<int> sut = new DatabaseT<int>();

            Exception ex = Assert.Throws<InvalidOperationException>(() => sut.Remove());

            Assert.AreEqual(DBEmptyMsg, ex.Message);
        }

        [Test]
        public void FetchingDatabaseReturnsCorrectCollection()
        {
            DatabaseT<int> sut = new DatabaseT<int>(Enumerable.Range(0, 16).ToArray());
            int[] numbers = Enumerable.Range(0, 16).ToArray();

            int[] returnedCollection = sut.Fetch();

            Assert.IsTrue(numbers.SequenceEqual(returnedCollection));
        }

        [Test]
        public void FetchEmptyDatabaseReturnsEmptyCollection()
        {
            DatabaseT<int> sut = new DatabaseT<int>();
            int[] numbers = new int[0];

            int[] returnedCollection = sut.Fetch();

            Assert.IsTrue(numbers.SequenceEqual(returnedCollection));
        }
    }
}