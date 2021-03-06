﻿using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
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
            _player.DamageResistance = damageResistance;    //automation code
        }
      

        [Given(@"I'm an Elf")]
        public void GivenIMAnElf()
        {
            _player.Race = "Elf";   //automation code
        }


        [Given(@"I have the following attributes")]
        public void GivenIHaveTheFollowingAttributes(Table table) //Table class from SF
        {
            //using LINQ to get the first row where attribute equals the given attribute and grabbing the value
            //var damageResistance = table.Rows.First(row => row["attribute"] == "damageResistance")["value"];
            //var race = table.Rows.First(row => row["attribute"] == "race")["value"];

            //SF automaps table data to an instance of this PlayerAttributes class
            //var attributes = table.CreateInstance<PlayerAttributes>();

             dynamic attributes = table.CreateDynamicInstance();

            _player.DamageResistance = attributes.DamageResistance; 
            _player.Race = attributes.Race;

        }


        [Given(@"My character class is set (.*)")]
        public void GivenMyCharacterClassIsSetHealer(CharacterClass characterClass)
        {
            _player.CharacterClass = characterClass;
        }

        [When(@"Cast a healing spell")]
        public void WhenCastAHealingSpell()
        {
            _player.CastHealingSpell();
        }



    }
}
