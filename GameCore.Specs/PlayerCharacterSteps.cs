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

        [When(@"I take hit to the body that is 50 damage")]
        public void WhenITakeHitToTheBodyThatIsDamage()
        {
            _player.HitOnBody(50);
        }

        [Then(@"My health should now be 50")]
        public void ThenMyHealthShouldNowBe50()
        {
            Assert.Equal(50, _player.Health);
        }

        
        [When(@"I take 2 hits to the body that is 100 damage")]
        public void WhenITakeHitsToTheBodyThatIsDamage()
        {
            _player.HitOnBody(100);
        }

        
        [Then(@"I should be dead")]
        public void ThenIShouldBeDead()
        {
            Assert.Equal(0, _player.Health);
        }



    }
}
