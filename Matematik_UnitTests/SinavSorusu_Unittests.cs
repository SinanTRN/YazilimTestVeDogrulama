using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik_UnitTests
{
    [TestFixture]
    public class SinavSorusu_Unittests
    {
        SinavSorusu soru;
        [SetUp] 
        public void SetUp() 
        {
            soru = new SinavSorusu();
        }

        [Test]
        public void yazdir_OnBeseBolum_ReturnHepsi()
        {
            var result = soru.yazdir(15);
            Assert.That(result, Is.EqualTo("Gumushane"));
        }
        [Test]
        public void yazdir_UceBolum_ReturnBas()
        {
            var result = soru.yazdir(3);
            Assert.That(result, Is.EqualTo("Gumus"));
        }
        [Test]
        public void yazdir_BeseBolum_ReturnSon()
        {

            var result = soru.yazdir(5);
            Assert.That(result, Is.EqualTo("hane"));
        }
        [Test]
        public void yazdir_Bolunmeyen_ReturnSayi()
        {
            var result = soru.yazdir(8);
            Assert.That(result, Is.EqualTo("8"));
        }
    }
}
