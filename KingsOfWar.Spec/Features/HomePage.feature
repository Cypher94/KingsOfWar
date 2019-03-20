Feature: HomePage
	In order see informations about the game
	As a Visitor
	I want to have Home Page with game description and recent news

Background:
	Given I am on Home Page

Scenario: Home Page is displayed correctly
	Then I should see following elements displayed
	| element			|
	| Navigation		|
	| About section		|
	| Game info section |
	| Articles Section  |
	| Footer            |

Scenario: Articles are displayed correctly
	Then I should see Articles with following elements displayed
	| element         |
	| Title           |
	| Description     |
	| ReadMore button |

#TODO: Test readmore and check single article when styled
