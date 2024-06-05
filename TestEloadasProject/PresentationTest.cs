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

        public void Engage_NotTheRightSpace()
        {
            p.Engage();
            p.Engage();
            p.Engage();
            p.Engage();
            Assert.That(p.Engage(), Is.False);
        }

        [Test]

        public void Engage_RightSpace()
        {

            Assert.That(p.Engage(), Is.True);
        }

        [Test]

        public void getFreeSpaces_()
        {
            //konstruktor, ha nincs, osszes, ha van csak annyit amennyi van, túl sokszor hłvódik meg
        }

        [Test]

        public void getFull_FreeSpacesNull()
        {
            //az utolso szabad helyig lehet foglalni csak
            Assert.That(p.getFull(0), Is.True);
        }

        [Test]

        public void AlreadyTaken_indexTaken()
        {
            //indexeltolas
            Assert.That(p.AlreadyTaken(2, 2), Is.True);
        }
    }
}
