using TechTalk.SpecFlow;

namespace GameCore.Specs
{
    [Binding]
    public class PlayerCharacterSteps
    {
        [Given(@"I'm a new player")]
        public void GivenImANewPlayer()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I take 0 damage")]
        public void WhenITakeDamage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"My health should now be 100")]
        public void ThenMyHealthShouldNowBe()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
