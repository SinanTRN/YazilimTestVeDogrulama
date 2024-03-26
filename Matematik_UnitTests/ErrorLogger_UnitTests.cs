using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik_UnitTests
{
    [TestFixture]
    public class ErrorLogger_UnitTests
    {
        ErrorLogger logger;
        [SetUp] 
        public void SetUp() 
        { 
            logger = new ErrorLogger();
        }
        [Test]
        public void Log_WhenCalled_ReturnLastErrorDegisti()
        {
            logger.Log("Hata!!");
            Assert.That(logger.LastError, Is.EqualTo("Hata!!"));
        }
        [Test]
        [TestCase("")]
        [TestCase(" ")]
       // [TestCase(null)]
        public void Log_InvalidError_ReturnArgumentNullExp(string error)
        {
            //logger.Log(error);
            Assert.That(()=> logger.Log(error), Throws.ArgumentNullException);
        }

    }
}
