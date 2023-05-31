Feature: TMFeature

As a TurnUp Portal Admin
Iwould like to create, edit time and material records
So that I can manage employee's time and materials successfully

Scenario: Create Time and Material record with valid details 
	Given I logged into TurnUp portal successfully
	When I navigate Time and Material record
	And I create a new Time and Material reocrd 
	Then The record should be created successfully





