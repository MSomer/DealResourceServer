using ResourceServer.Repositories;
using ResourceServer.Repositories.Interfaces;
using ResourceServer.Repositories.Memory;
using ResourceServer.Model.Deal;

namespace UnitTestProjectResourceServer
{
    [TestClass]
    public class DealRepositoryUnitTest
    {
        [TestMethod]
        public void Test_CreateDeal_DealIsCreated()
        {
            //Arrange
            IDealRepository dealRepository = new DealRepository(new DealContextInMemory());
            //Act
            var createdDeal = dealRepository.createDeal(new DealDto());
            //Assert
            Assert.IsNotNull(createdDeal);
        }
    }
}