using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Matematik_UnitTests
{
    [TestFixture]
    public class HtmlFormatter_Tests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ReturnBold()
        {
            var formatter = new HtmlFormatter();
            var result = formatter.FormatAsBold("Abc");
            
            //Assert.That(result,Does.StartWith("<strong>"));//Çok genel bir ifade.returnun sonunu silsek de yine çalışır
            //Assert.That(result, Does.EndWith("</strong>"));//Hala genel bir ifade.returnun ortası olmasa da çalışır
            //Assert.That(result,Does.Contain("abc"));//Content'e başka bir tane daha content daha olmamalı

            Assert.That(result, Is.EqualTo("<strong><abc</strong>").IgnoreCase);// IgnoreCase ile birlikte büyük küçük harf duyarlılığı olmasın
        }
    }
}
