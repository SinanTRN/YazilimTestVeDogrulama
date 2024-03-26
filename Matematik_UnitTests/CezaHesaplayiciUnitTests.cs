using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Matematik_UnitTests
{
    [TestFixture]
    public class CezaHesaplayiciUnitTests
    {
        CezaHesaplayici nesne;
        [SetUp]
        public void SetUp() { 
            nesne=new CezaHesaplayici();
        }
        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void hesaplaCeza_AsimOldugunda_ReturnOutOfExp(int a) 
        {
            
            Assert.That(() => nesne.hesaplaCeza(a), Throws.TypeOf<ArgumentOutOfRangeException>());
        }
        [Test]
        [TestCase(0,0)]
        [TestCase(65,0)]
        [TestCase(64,0)]
        [TestCase(66,0)]
        [TestCase(300,47)]
        [TestCase(85,4)]
        public void hesaplaCeza_SinirlarIcınde_ReturnCezaPuani(int a,int cp)
        {
            var result = nesne.hesaplaCeza(a);
            Assert.That(result, Is.EqualTo(cp));
        }
    }
}
