Feature: PlayerCharacter
	In order to play the game
	As a human player
	I want my character attributes to be correctly represented


Scenario: Taking no damage when hit doesn't affect health
	Given I'm a new player
	When I take 0 damage 
	Then My health should now be 100

Scenario: Starting health is reduced when hit in the body
	Given I'm a new player
	When I take hit to the body that is 50 damage
	Then My health should now be 50

Scenario: Taking too many hits to the body result in player death
	Given I'm a new player
	When I take 2 hits to the body that is 100 damage
	Then I should be dead