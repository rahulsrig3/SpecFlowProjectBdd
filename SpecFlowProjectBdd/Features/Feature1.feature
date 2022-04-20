Feature: Create New Orgnization

A short summary of the feature


Scenario: Already user in Home page and want to create new organization with mandatory fields
	Given launch "chrome" browser
	And enter the URL "http://localhost:8888/"
	And in login page enter username "admin" and password "admin"
	And click on login
	When Home page is displayed click on create organization
	And click on create organization image icon
	And enter organization name as "google"
	Then validate whether organization is created with the name "google"


	

