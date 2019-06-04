using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattlemonASP;
using BattlemonASP.DataLayer.Context;
using BattlemonASP.Models.Classes;
using TestUserContext = BattlemonASP.DataLayer.Context.TestUserContext;
using BattlemonASP.DataLayer.Repositories;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        TestUserContext testUserContext;
        BattlemonRepo battlemonRepo;

        public UnitTest1()
        {
            testUserContext = new TestUserContext();
            battlemonRepo = new BattlemonRepo(new TestBattlemonContext());
        }

        [TestMethod]
        public void Login()
        {
            User user = new User(1, "Iets@iets.com", "Iets@iets.com", "Iets.1");
            bool x = testUserContext.Login(user);
            Assert.AreEqual(true, x);
        }

        [TestMethod]
        public void GetBattlemonByID()
        {
            Battlemon battlemon = new Battlemon(1, "Darpheye", 210, 70, 90, 40, "Steel/Poison", "Darpheye front.png", "Darpheye back.png");
            battlemonRepo.GetBattlemonByID(battlemon.BattlemonID);
            Assert.AreEqual(1, battlemon.BattlemonID);
        }
    }
}
