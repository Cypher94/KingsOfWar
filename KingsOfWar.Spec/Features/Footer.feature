Feature: Footer
	In order to have extended navigation options for external pages
	As a Visitor
	I want to have Footer with other links

Background: 
	Given I am on a page with Footer

Scenario: Footer is displayed
	Then I should see Footer with following elements:
		| Element         |
		| Forum button    |
		| Help button     |
		| Support button  |
		| Facebook button |

Scenario: Footer is redirecting to Forum Page
	When I press Footer Forum Button
	Then I should be redirected to Forum Page

Scenario: Footer is redirecting to Help Page
	When I press Footer Help Button
	Then I should be redirected to Help Page

Scenario: Footer is redirecting to Support Page
	When I press Footer Support Button
	Then I should be redirected to Support Page

Scenario: Footern is redirecting to Facebook Page
	When I press Footer Facebook Button
	Then I should be redirected to Facebook Page

