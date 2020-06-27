@countries
Feature: RestCountries
	check status code for countries

Scenario: check status code rest countries
	Given I get information for all countries of the world
	Then the status code should be 200