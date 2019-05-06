Feature: Checkable selector

Scenario Outline: checking inputs
	Given injecting browser content
	| Html   |
	| <html> |
	When checking element '<target>'
	Then the element '<target>' has the value '<value>'
Examples: 
	| description  | target | value   | html                                                                                          |
	| value        | target | checked | <input type="checkbox" id="i1" name="target" value="Bob"></input><label for="i1">noop</label> |
	| label for    | target | checked | <input type="checkbox" id="i1" name="target" value="noop"></input><label for="i1">Bob</label> |
	| label nested | target | checked | <label>Bob<input type="checkbox" name="target" value="noop"></input></label>                  |
	| no value     | target | checked | <label>target<input type="checkbox"></input></label>                                          |
	| checked      | target | checked | <label>target<input type="checkbox" checked></input></label>                                  |


Scenario Outline: unchecking inputs
	Given injecting browser content
	| Html   |
	| <html> |
	When unchecking element '<target>'
	Then the element '<target>' has the value '<value>'
Examples: 
	| description         | target | value     | html                                                         |
	| unchecking          | target | unchecked | <label>target<input type="checkbox"></input></label>         |
	| unchecking  checked | target | unchecked | <label>target<input type="checkbox" checked></input></label> |
Scenario Outline: error messages
	Given injecting browser content
	| Html   |
	| <html> |
	Given an error is expected
	When entering '<value>' into element '<target>'
	Then the Error has values
    | Message |
    | <error> |
Examples: 
	| description | target | value   | html                                                                                     | error                   |
	| value       | target | checked | <input type="checkbox" id="i1" name="t" value="Bob"></input><label for="i1">noop</label> | /element was not found/ |