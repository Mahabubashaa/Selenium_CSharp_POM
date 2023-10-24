Feature: This Feature is intended to validate the consumer portal

@CreateReport
Scenario: Create Credit Report in Consumer portal
	Given Login to Consumer portal
	When Enter the Consumer FirstName and LastName
	Then Click Next Button

Scenario: Create Credit Report by entering SSN
	Given Login to Consumer portal
	When Enter the Consumer SSN
	Then Click Next Button