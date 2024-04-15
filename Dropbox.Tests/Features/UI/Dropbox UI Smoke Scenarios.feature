@UI
Feature: Dropbox UI Smoke Scenarios

Dropbox UI Smoke Scenarios

@Smoke
Scenario: User can't sign up for free with wrong Email
	Given I navigate to the Dropbox Main page
	When I set 'Test' value to 'Sign Up Email' control at the 'Main Section' container on the Main page
	And I click on 'Sign Up For Free' control at the 'Main Section' container on the Main page
	Then 'Sign Up Error Message' control at the 'Main Section' container is 'Displayed' on the Main page
	And 'Sign Up Error Message' control at the 'Main Section' container has value on the Main page
		```
		An email address must contain a single @
		```

@Smoke
Scenario Outline: User can't login/sign up with wrong Email
	Given I navigate to the Dropbox Main page
	When I click on '<Button Name>' control at the 'Header Section' container on the Main page
	And I wait for the page to be loaded
	When I set 'Test' value to 'Email' control at the 'Login Section' container on the Login page
	And I click on 'Continue' control at the 'Login Section' container on the Login page
	Then 'Error Message' control at the 'Login Section' container is 'Displayed' on the Login page
	And 'Error Message' control at the 'Login Section' container has value on the Login page
		```
		An email address must contain a single @
		```

	Examples: 
		| Button Name |
		| Login       |
		| Sign up     |

@Smoke
Scenario Outline: The correct Data is displayed for Billed Yearly test plans
	Given I navigate to the Dropbox Main page
	When I click on 'Get Started' control at the 'Header Section' container on the Main page
	And I wait for the page to be loaded
	Then The Plan with '<Name>' name has following data:
		| Type   | Price   | Users   | Storage   | Transfer Files   | Restore Dayes   |
		| <Type> | <Price> | <Users> | <Storage> | <Transfer Files> | <Restore Dayes> |

	Examples: 
		| Name          | Type              | Price              | Users    | Storage                      | Transfer Files              | Restore Dayes                     |
		| Plus          | For personal use  | $9.99 / month      | 1 user   | 2 TB of storage              | Transfer files up to 50 GB  | 30 days to restore deleted files  |
		| Essentials    | For professionals | $16.58 / month     | 1 user   | 3 TB of storage              | Transfer files up to 100 GB | 180 days to restore deleted files |
		| Business      | For teams         | $15 / user / month | 3+ users | Starts at 9 TB for the team  | Transfer files up to 100 GB | 180 days to restore deleted files |
		| Business Plus | For companies     | $24 / user / month | 3+ users | Starts at 15 TB for the team | Transfer files up to 250 GB | 1 year to restore deleted files   |