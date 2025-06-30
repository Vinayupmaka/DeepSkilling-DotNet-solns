using CustomerCommLib;
using Moq;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class CustomerCommTests
    {
        private Mock<IMailSender> _mockMailSender;
        private CustomerComm _customerComm;

        [OneTimeSetUp]
        public void Setup()
        {
            _mockMailSender = new Mock<IMailSender>();
            _mockMailSender
                .Setup(sender => sender.SendMail(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(true);

            CustomerCommLib.CustomerComm _customerComm = new CustomerCommLib.CustomerComm(_mockMailSender.Object);

        }

        [Test]
        public void SendMailToCustomer_ShouldReturnTrue()
        {
            var result = _customerComm.SendMailToCustomer();
            Assert.That(result, Is.True);
        }
    }
}
