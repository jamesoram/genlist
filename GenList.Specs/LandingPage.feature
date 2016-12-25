Feature: Landing on the site displays marketing copy
	In order to generate leads
	As a product owner
	I want to inform my future customers of the product being built

@landing
Scenario: The user sees marketing copy
	Given I have landed on the page
	When I look at the page
	Then I see the marketing copy

@Landing
Scenario: The user sees a call to action
	Given I have landed on the page
	When I look at the page
	Then I see a call to action
