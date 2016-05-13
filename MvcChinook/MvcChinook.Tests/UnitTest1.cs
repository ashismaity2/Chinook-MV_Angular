using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcChinook.Controllers;
using MvcChinook.Services;
using Moq;

namespace MvcChinook.Tests
{
    [TestClass]
    public class ChinookControllerTests
    {
        private Mock<IAppService> mockAppService;

        [TestInitialize]
        public void SetupTests()
        {
            mockAppService = new Mock<IAppService>();

            //mockAppService.Setup(m => m.UpdatePerson(It.IsAny())).Returns((Person p) => { return SetupOperationStatus(p); });
        }

        //private OperationStatus SetupOperationStatus(Person p)
        //{
        //    var opStatus = new OperationStatus();
        //    opStatus.Data = p;

        //    return opStatus;
        //}

        [TestMethod]
        public void TestChinookIndex()
        {
            ChinookController ChinookController = new ChinookController(mockAppService.Object);

  


            JsonResult result = ChinookController.Index();


        }
    }

}
