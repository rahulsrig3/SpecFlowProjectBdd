Feature: Create new organization with multiple values
A short summary of the feature

Background: 
	#Given open the browser and enter the url "http://localhost:8888/"
	#When enter valid usename "admin" and password "admin"
	#When click on login button
	When click on organization link
	When click on new organization icon

Scenario: Already user in Home page and want to create new organization with mandatory fields
	#Given open the browser and enter the url "http://localhost:8888/"
	#When enter valid usename "admin" and password "admin"
	#When click on login button
	#When click on organization link
	#When click on new organization icon
	When enter organization as "gusu"
	And click on save button
	Then validate the text

Scenario Outline: Login to application and create a new organization with different organization name
	#Given open the browser and enter the url "http://localhost:8888/"
	#When enter valid usename "admin" and password "admin"
	#When click on login button
	#When click on organization link
	#When click on new organization icon
	When enter organization "<name>"
	And click on save button
	Then validate the text

	Examples: 
	|name		|  
	|sunday4	|  
	|monday4	| 
	|tuesday4	|  