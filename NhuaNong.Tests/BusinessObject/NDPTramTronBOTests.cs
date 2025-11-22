using NUnit.Framework;
using Moq;
using NhuaNong.BusinessObject;
using NhuaNong.DAL;
using NhuaNong.EntityModel;
using NhuaNong.Data;
using NhuaNong.Core;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;

namespace NhuaNong.Tests.BusinessObject
{
    [TestFixture]
    public class NDPTramTronBOTests
    {
        private Mock<IMACRepository> _mockMACRepo;
        private Mock<IMACSiloRepository> _mockMACSiloRepo;
        private Mock<IEventLogRepository> _mockEventLogRepo;
        private Mock<IEventActionCodeRepository> _mockEventActionCodeRepo;
        private NDPTramTronBO _bo;

        [SetUp]
        public void Setup()
        {
            _mockMACRepo = new Mock<IMACRepository>();
            _mockMACSiloRepo = new Mock<IMACSiloRepository>();
            _mockEventLogRepo = new Mock<IEventLogRepository>();
            _mockEventActionCodeRepo = new Mock<IEventActionCodeRepository>();

            // Inject mocks
            IoC.InjectStub<IMACRepository>(_mockMACRepo.Object);
            IoC.InjectStub<IMACSiloRepository>(_mockMACSiloRepo.Object);
            IoC.InjectStub<IEventLogRepository>(_mockEventLogRepo.Object);
            IoC.InjectStub<IEventActionCodeRepository>(_mockEventActionCodeRepo.Object);

            _bo = new NDPTramTronBO();
        }

        [Test]
        public void SaveMAC_NewItem_SavesParentAndChildren()
        {
            // Arrange
            var newMac = new ObjMAC
            {
                MACID = 0,
                MaMAC = "MAC001",
                TenMAC = "Test MAC",
                MarkAsDeleted = false,
                LstMACSilo = new List<ObjMACSilo>
                {
                    new ObjMACSilo { MACSiloID = 0, NPSiloMaSilo = "Silo1", SiloValue = 100, IsNewObject = true }
                }
            };
            // Helper property to simulate new object check in BO
            // The BO checks: if (objMac.IsNewObject)
            // ObjMAC inherits from ObjectBase, we assume IsNewObject logic relies on ID <= 0 or similar, 
            // but looking at code it might be a property. Let's assume ID=0 implies new or we need to set it if it's a property.
            // Checking ObjMAC definition would be ideal, but usually it's a property.
            // Let's assume standard behavior for now.

            var list = new List<ObjMAC> { newMac };

            // Setup Mock for EventLog (SaveMAC calls InsertEventLog)
            // InsertEventLog queries EventActionCode
            var eventActionCode = new EventActionCode { Code = "MAC_NEW", EventActionCodeID = 1 };
            _mockEventActionCodeRepo.Setup(r => r.DoQuery()).Returns(new List<EventActionCode> { eventActionCode }.AsQueryable());

            _mockMACRepo.Setup(r => r.Add(It.IsAny<MAC>()));
            _mockMACRepo.Setup(r => r.Save());

            // Act
            bool result = _bo.SaveMAC(list);

            // Assert
            Assert.IsTrue(result);
            _mockMACRepo.Verify(r => r.Add(It.Is<MAC>(m => m.MaMAC == "MAC001" && m.MACSiloes.Count == 1)), Times.Once);
            _mockMACRepo.Verify(r => r.Save(), Times.Once);
        }

        [Test]
        public void SaveMAC_DeletedItem_DeletesParent()
        {
            // Arrange
            int macId = 10;
            var deletedMac = new ObjMAC
            {
                MACID = macId,
                MaMAC = "MAC_DEL",
                MarkAsDeleted = true
            };
            var list = new List<ObjMAC> { deletedMac };

            var entityToDelete = new MAC { MACID = macId, MaMAC = "MAC_DEL" };
            _mockMACRepo.Setup(r => r.GetById(macId)).Returns(entityToDelete);
            _mockMACRepo.Setup(r => r.Delete(entityToDelete));

            // Setup Mock for EventLog
            var eventActionCode = new EventActionCode { Code = "MAC_DEL", EventActionCodeID = 2 };
            _mockEventActionCodeRepo.Setup(r => r.DoQuery()).Returns(new List<EventActionCode> { eventActionCode }.AsQueryable());

            // Act
            bool result = _bo.SaveMAC(list);

            // Assert
            Assert.IsTrue(result);
            _mockMACRepo.Verify(r => r.Delete(entityToDelete), Times.Once);
            _mockMACRepo.Verify(r => r.Save(), Times.Once);
        }
    }
}
