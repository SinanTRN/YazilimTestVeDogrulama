using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Matematik.CustomerController;
using static Matematik.CustomerController.NotFound;


namespace Matematik_UnitTests
{

    [TestFixture]
    public class CustomerController_Tests
    {
        CustomerController controller;
        [SetUp]
        public void Setup() 
        { 
            controller = new CustomerController();
        }
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            
            var result = controller.GetCustomer(0);

            
            //Assert.IsInstanceOf<NotFound>(result);
            //Assert.That(result, Is.InstanceOf<NotFound>());//Kendisi ve türevleri için geçerli olurdu
            Assert.That(result, Is.TypeOf<NotFound>());//Sadece ve sadece geçerli class ın tipinde mi? türevleri yok
        }
        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {        
            var result = controller.GetCustomer(2);
            Assert.That(result, Is.TypeOf<Ok>());//Sadece ve sadece geçerli class ın tipinde mi? türevleri yok
        }
    }
}
