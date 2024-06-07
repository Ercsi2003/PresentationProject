using NUnit.Framework.Internal;
using PresentationProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEloadasProject
{
    internal class PresentationTest
    {
        Presentation p;

        [SetUp]

        public void Setup()
        {
            p = new Presentation(2, 2);
        }

        [Test]

        public void Reservation_NoAvailableSeat()
        {
            p.Reservation();
            p.Reservation();
            p.Reservation();
            p.Reservation();
            Assert.That(p.Reservation(), Is.False);
        }

        [Test]

        public void Reservation_AvailableSeat()
        {

            Assert.That(p.Reservation(), Is.True);
        }

        [Test]

        public void getNumOfFreeSeats_ReturnsCorrectCount()
        {
            Assert.That(4, Is.EqualTo(p.getNumOfFreeSeats()));
            p.Reservation();
            Assert.That(3, Is.EqualTo(p.getNumOfFreeSeats()));
        }

        [Test]

        public void getFull_FreeSeatsZero_returnsTrue()
        {
            p.Reservation();
            Assert.True(p.getFull());
        }

        [Test]

        public void getFull_FreeSeatsAvailable_returnsFalse()
        {
            p.Reservation();
            Assert.False(p.getFull());
        }

        [Test]

        public void AlreadyReservedSeat_indexTaken_returnsTrue()
        {
            p.Reservation();
            Assert.True(p.AlreadyReservedSeat(1,1));
        }

        [Test]

        public void AlreadyReservedSeat_InvalidInputs()
        {
            Assert.Throws<ArgumentException>(() => p.AlreadyReservedSeat(0, 1));
            Assert.Throws<ArgumentException>(() => p.AlreadyReservedSeat(12, 6));
        }
    }
}
