using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MVVMPractice.UnitTests
{
    [TestClass]
    public class MainViewModelTests
    {
        [TestMethod]
        public void SayHelloCommandTest()
        {
            //arrange
            var mainViewmodel = new MainViewModel();
            mainViewmodel.Name = "Paul";
            //act
            mainViewmodel.SayHelloCommand.Execute(null);
            //assert
            Assert.AreEqual("Hello Paul",mainViewmodel.HelloMessage);
        
        }
    }
}
