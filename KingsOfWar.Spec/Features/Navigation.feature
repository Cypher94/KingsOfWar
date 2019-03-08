Feature: Navigation
	In order navigate through pages
	As a Visitor
	I want to have Navigation

Background: 
	Given I have entered the page with Navigation

Scenario: Navigation is displayed
	Then I should see Navigation with following elements:
	| Element             |
	| Logo                |
	| Home Button         |
	| Lore Button         |
	| Rules Button        |
	| Campaign Button     |
	| Army Builder Button |


Scenario: Navigation redirect
	When I press Navigation button
	Then I should be redirected to other page
