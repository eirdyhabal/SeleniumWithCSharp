﻿Feature: Login

Check if Login functionality works

@tag1
Scenario: Login user as Administrator
	Given I navigate to application
	And I click the Login link
	And I enter username and password
	| UserName | Password |
	| admin    | password |
	And I click login
	Then I should see user logged in to the application
