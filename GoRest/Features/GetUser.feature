Feature: GetUser

Background: 
	Given I set GET users api endpoint as '/users'
	And I set headers 'Accept' and 'Content-Type' as 'application/json'

@mytag
Scenario: Get data of all users
	When I send GET Http request
	Then I receive valid http status code '200'
	And Response body is not null

Scenario Outline: Get data of users with specific User ID
	When I set User ID as '<userId>'
	And I send GET Http request
	Then I receive the response with user details
	And I receive valid http status code '200'
	And Response body is not null

	Examples:
		| TestCase | userId |
		| 1        | 40     |
		| 2        | 41     |
		| 3        | 42     |