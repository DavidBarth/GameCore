using TechTalk.SpecFlow;
using Xunit;

namespace GameCore.Specs
{
    [Binding]
    public class PlayerCharacterSteps
    {

        private PlayerCharacter _player;


        //using regular expressions we can change method names later due to indireciton in the regex
        [Given(@"I'm a new player")]
        public void GivenImANewPlayer()
        {
            _player = new PlayerCharacter();    
        }

        
        
        [When(@"I take 0 damage")]
        public void WhenITake0Damage()
        {
            _player.HitOnHead(0);
        }
        
        [Then(@"My health should now be 100")]
        public void ThenMyHealthShouldNowBe100()
        {
            Assert.Equal(100, _player.Health);
        }
    }
}
