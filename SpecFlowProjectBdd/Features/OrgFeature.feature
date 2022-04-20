Feature: OrgFeature

A short summary of the feature

Scenario Outline: Login to application and create a new organization with different organization name
	Given open browser and enter the url "http://localhost:8888/"
	When enter the valid usename "admin" and password "admin"
	When click on the login button
	When click on the organization link
	When click on the new organization icon
	When enter the organization "<name>"
	And click on the save button
	Then validate text

	Examples: 
	|name		|  
	|sunday5	|  
	|monday5	| 
	|tuesday5	|  
