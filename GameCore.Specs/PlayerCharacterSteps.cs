using TechTalk.SpecFlow;
using Xunit;

namespace GameCore.Specs
{
    [Binding]
    public class PlayerCharacterSteps
    {
        private PlayerCharacter _player;


        //Arrange
        [Given(@"I'm a new player")]
        public void GivenIMANewPlayer()
        {
            _player = new PlayerCharacter();
        }
        

        [When(@"I take (.*) damage")]
        public void WhenITakeDamage(int damage)
        {
            _player.Hit(damage);
        }

               
        //Assert
        [Then(@"My health should now be 100")]
        public void ThenMyHealthShouldNowBe()
        {
            Assert.Equal(100, _player.Health);
        }


        //Assert
        [Then(@"My health should now be 60")]
        public void ThenMyHealthShouldNowBe60()
        {
            Assert.Equal(60, _player.Health);
        }

        //Assert
        [Then(@"I should be dead")]
        public void ThenIShouldBeDead()
        {
            Assert.Equal(true, _player.IsDead);
        }





    }
}
