Feature: Google search

@search
Scenario: Search for "ThoughtWorks"
	Given I'm on the google australia search page
	When I search for "ThoughtWorks"
	Then the results page title should be "ThoughtWorks - Google Search"