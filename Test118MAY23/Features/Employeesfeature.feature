Feature: EmployeesFeature

TurnUp Portal Admin
On the Employees Page - I want to create Edit and Delete Employee Records
This will make easier to manage employees records daily basis 


Scenario: Create Employees records with valid details
	Given I logged in to Turnup portal successfully
	When I navigate to Employees page 
	And I create a new Employee record
	Then New Employee record should be ctreate successfully



