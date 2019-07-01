@injected-html
Feature: Alerts

Scenario: Dismissing an alert
	Given injecting browser content
	| Html  | Script            |
	| empty | alert("bubbles"); |
	When dismissing the alert

Scenario: Accepting an confirm
	Given injecting browser content
	| Html  | Script                     |
	| empty | window.confirm("bubbles"); |
	When accepting the alert

Scenario: Dismissing an confirm
	Given injecting browser content
	| Html  | Script                     |
	| empty | window.confirm("bubbles"); |
	When dismissing the alert

Scenario: Check alert text
	Given injecting browser content
	| Html  | Script            |
	| empty | alert("bubbles"); |
	Then the alert has the value 'bubbles'
	When dismissing the alert

Scenario: Check confirm text
	Given injecting browser content
	| Html  | Script                     |
	| empty | window.confirm("bubbles"); |
	Then the alert has the value 'bubbles'
	When dismissing the alert