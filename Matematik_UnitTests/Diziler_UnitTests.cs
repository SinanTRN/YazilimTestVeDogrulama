using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik_UnitTests
{
    [TestFixture]
    public class Diziler_UnitTests
    {
        [Test]
        public void tekSayi_LimitPozitif_ReturnLimiteKadarTekSayi()
        {
            var dizi = new Diziler();
            var result = dizi.tekSayi(5);

            //Assert.That(result, Is.Not.Empty);//Genel bir test oldu
            //Assert.That(result.Count, Is.EqualTo(3));//Halen daha genel

            //Amelelik ve çok spesifik
            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));

            //yeterli
            //Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            //Assert.That(result, Is.Ordered);//Gelen Dizi sıralı mı?

            Assert.That(result, Is.Unique);//elemanlar benzersiz mi
        }
        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void tekSayi_LimitPozitifDegil_ReturnCount0(int a)
        {
            var dizi = new Diziler();
            var result=dizi.tekSayi(a);
            Assert.That(result.Count, Is.EqualTo(0));
        }
    }
}
