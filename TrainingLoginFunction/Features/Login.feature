Feature: Login
	As a registered user of Giftrete
	I would like to log in
	So that I can use the site

@mytag
Scenario: Invalid Login1 to the Site
	Given I navigate to the site
	When I I click on the Login link
	And I enter Invalid username
	And I enter password
	And I click on login button
	Then I am not logged in to the site


Scenario: Valid Login to the Site
	Given I navigate to the site
	When I I click on the Login link
	And I enter Valid username
	And I enter Valid password
	And I click on login button
	Then I am logged in to the site	


	Scenario: Invalid Login2 to the Site
	Given I navigate to the site
	When I I click on the Login link
	And I enter Valid username
	And I enter InValid password
	And I click on login button
	Then I am not logged in to the site with wrong credentials