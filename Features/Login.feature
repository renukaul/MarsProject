Feature: Login

A short summary of the feature

Scenario: User should loginwith valid credentials
	Given user is in talent application and user is on login page
	When user enters a valid '<username>' and '<password>'
	Then user should login  successfully

	Examples: 
	| username              | password   |
	| renukaul955@gmail.com | target@123 |