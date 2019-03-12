Feature: Navigation
	In order navigate through pages
	As a Visitor
	I want to have Navigation


Scenario: Navigation is displayed
	Given I have entered the page with Navigation
	Then I should see Navigation with following elements:
	| Element             |
	| Logo                |
	| Home Button         |
	| Lore Button         |
	| Rules Button        |
	| Campaign Button     |
	| Army Builder Button |

Scenario: Navigation is redirecting to Home Page
	Given I am on other page than Home
	When I press Navigation Home Button
	Then I should be redirected to Home Page


Scenario: Navigation is redirecting to Lore
	Given I am on other page than Lore
	When I press Navigation Lore Button
	Then I should be redirected to Lore Page


Scenario: Navigation is redirecting to Rules Page
	Given I am on other page than Rules
	When I press Navigation Rules Button
	Then I should be redirected to Rules Page


Scenario: Navigation is redirecting to Campaign Page
	Given I am on other page than Campaign
	When I press Navigation Campaign Button
	Then I should be redirected to Campaign Page


Scenario: Navigation is redirecting to Army Builder Page
	Given I am on other page than Army Builder
	When I press Navigation Army Builder Button
	Then I should be redirected to Army Builder Page
