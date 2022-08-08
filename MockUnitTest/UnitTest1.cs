using NUnit.Framework;
using MockEsim;
using Moq;
using System;

namespace MockUnitTest
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            //arrange
            Mock<Koira> aiti = new Mock<Koira>();
            Mock<Koira> isi = new Mock<Koira>();

            aiti.Setup(aiti => aiti.onSukuKypsä()).Returns(() => true);
            isi.Setup(x => x.onSukuKypsä()).Returns(() => true);
            Koira pentu = null;
            //act
            pentu = Koira.pennunTeko(aiti.Object, isi.Object);

            //assert
            Assert.IsNotNull(pentu);
        }

        [Test]
        public void Test2()
        {
            Mock<Koira> aiti = new Mock<Koira>();
            Mock<Koira> isi = new Mock<Koira>();

            aiti.Setup(aiti => aiti.onSukuKypsä()).Returns(() => true);
            isi.Setup(x => x.onSukuKypsä()).Returns(() => false);
            

            Assert.Throws<ArgumentException>(() =>Koira.pennunTeko(aiti.Object, isi.Object));

            //NUnit.Framework.Assert.IsNotNull(pentu);
        }
    }
}