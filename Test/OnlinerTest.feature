﻿Feature: Onliner Test

Scenario: Onliner
	Given I navigate to http://onliner.by/ link
	When I click Login Icon on Main page
	And I enter testmailonliner@mail.ru email on Login Form
	And I enter Password1.default password on Login Form
	And I click login button on Login Form
	And I click RandomTab random tab on Tabs form
	Then There is RandomTab header on Catalog page
	When I logout on Main page