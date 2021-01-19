Feature: PostUser

Background:
	Given I set GET users api endpoint as '/users'
	And I set headers 'Accept' and 'Content-Type' as 'application/json'

@mytag
Scenario Outline: Create new user
	Given I set user '<name>', '<gender>', '<email>' and '<status>'
	When I send POST Http request
	Then I receive valid http status code '200'
	And I verify user details in response as '<name>', '<gender>', '<email>' and '<status>'

	Examples:
		| TestCases | name  | gender | email        | status |
		| 1         | David | Male   | ii@yahoo.com | Active |
		| 2         | John  | Male   | oo@yahoo.com | Active |
		| 3         | Mary  | Female | pp@yahoo.com | Active |
		| 4         | Sam   | Female | ss@yahoo.com | Active |