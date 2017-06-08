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
        
        //Act
        [When(@"I take (.*) damage")]
        public void WhenITakeDamage(int damage)
        {
            _player.Hit(damage);
        }

               
        //Assert
        [Then(@"My health should now be (.*)")]
        public void ThenMyHealthShouldNowBe(int expectedHealth)
        {
            Assert.Equal(expectedHealth, _player.Health);
        }


        //Assert
        [Then(@"I should be dead")]
        public void ThenIShouldBeDead()
        {
            Assert.Equal(true, _player.IsDead);
        }


        [Given(@"I have a damage resistance of (.*)")]
        public void GivenIHaveADamageResistanceOf(int damageResistance)
        {
            _player.DamageResistance = damageResistance;
        }
      

        [Given(@"I'm an Elf")]
        public void GivenIMAnElf()
        {
            _player.Race = "Elf";
        }

      



    }
}
