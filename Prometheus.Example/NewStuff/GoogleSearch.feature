Feature: Google search again

@search
Scenario: Search again for "ThoughtWorks"
	Given I'm on the google australia search page again
	When I search again for "ThoughtWorks"
	Then the results page title should be "ThoughtWorks - Google Search" again