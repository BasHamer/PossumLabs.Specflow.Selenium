Feature: Login

Scenario: Simple Login
	Given navigated to 'https://possumlabs.pipedrive.com/'
	When entering 'Admin.Email' into element 'Email'
	And entering 'Admin.Password' into element 'Password'
	And clicking the element 'Log in'
	Then the page contains the element 'Add deal'

