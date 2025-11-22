using NUnit.Framework;
using Moq;
using NhuaNong.BusinessObject;
using NhuaNong.DAL;
using NhuaNong.EntityModel;
using NhuaNong.Core;
using NhuaNong.Data;
using System.Collections.Generic;
using System.Linq;

namespace NhuaNong.Tests.BusinessObject
{
    [TestFixture]
    public class AdministrationBOTests
    {
        private Mock<ISEC_AssemblyRepository> _mockAssemblyRepo;
        private AdministrationBO _bo;

        [SetUp]
        public void Setup()
        {
            _mockAssemblyRepo = new Mock<ISEC_AssemblyRepository>();
            
            // Inject the mock into the IoC container
            IoC.InjectStub<ISEC_AssemblyRepository>(_mockAssemblyRepo.Object);

            _bo = new AdministrationBO();
        }

        [Test]
        public void GetSEC_AssemblyByKey_ValidId_ReturnsAssembly()
        {
            // Arrange
            int testId = 1;
            var expectedEntity = new SEC_Assembly { AssemblyID = testId, AssemblyInfo = "Test Assembly" };
            _mockAssemblyRepo.Setup(r => r.GetById(testId)).Returns(expectedEntity);

            // Act
            var result = _bo.GetSEC_AssemblyByKey(testId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(testId, result.AssemblyID);
            Assert.AreEqual("Test Assembly", result.AssemblyInfo);
            _mockAssemblyRepo.Verify(r => r.GetById(testId), Times.Once);
        }

        [Test]
        public void SaveSEC_Assembly_NewItem_CallsUpdate()
        {
            // Note: The implementation of SaveSEC_Assembly calls Update for non-deleted items, 
            // even if they might be conceptually "new" (based on the code logic provided).
            // It seems it relies on the repository to handle add/update or the logic is specific.
            // Looking at the code: 
            // if (objSEC_Assembly.MarkAsDeleted) ... Delete
            // else ... Update
            
            // Arrange
            var list = new List<ObjSEC_Assembly>
            {
                new ObjSEC_Assembly { AssemblyID = 1, AssemblyInfo = "New Assembly", MarkAsDeleted = false }
            };

            _mockAssemblyRepo.Setup(r => r.Update(It.IsAny<SEC_Assembly>()));
            _mockAssemblyRepo.Setup(r => r.Save());

            // Act
            _bo.SaveSEC_Assembly(list);

            // Assert
            _mockAssemblyRepo.Verify(r => r.Update(It.Is<SEC_Assembly>(a => a.AssemblyID == 1 && a.AssemblyInfo == "New Assembly")), Times.Once);
            _mockAssemblyRepo.Verify(r => r.Save(), Times.Once);
        }

        [Test]
        public void SaveSEC_Assembly_DeletedItem_CallsDelete()
        {
            // Arrange
            int deleteId = 2;
            var list = new List<ObjSEC_Assembly>
            {
                new ObjSEC_Assembly { AssemblyID = deleteId, MarkAsDeleted = true }
            };

            var entityToDelete = new SEC_Assembly { AssemblyID = deleteId };
            _mockAssemblyRepo.Setup(r => r.GetById(deleteId)).Returns(entityToDelete);
            _mockAssemblyRepo.Setup(r => r.Delete(entityToDelete));
            _mockAssemblyRepo.Setup(r => r.Save());

            // Act
            _bo.SaveSEC_Assembly(list);

            // Assert
            _mockAssemblyRepo.Verify(r => r.GetById(deleteId), Times.Once);
            _mockAssemblyRepo.Verify(r => r.Delete(entityToDelete), Times.Once);
            _mockAssemblyRepo.Verify(r => r.Save(), Times.Once);
        }
    }
}
