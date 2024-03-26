
using System.Collections.Generic;
namespace Matematik_UnitTests
{
    public class islem_UnitTests
    {
        private islem _math;
        [SetUp]
        public void Setup()
        {
            _math = new islem();
        }

        [Test]
        //[Ignore("Musteri artýk istemiyor!")] //Bu testi atla demek
        public void Add_WhenCall_ReturnTrue()
        {
            //var islem = new islem();
            int result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(3, 2, 3)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCall_ReturnExpectedResult(int a, int b, int expectedResult)
        {
            //var islem=new islem();
            int result= _math.Max(a, b);
            Assert.That(result,Is.EqualTo(expectedResult));
        }


    }
}