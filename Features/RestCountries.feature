@countries
Feature: RestCountries
	check status code for countries
	check United Kingdom exists in the list of countries

Scenario: check status code rest countries
	Given I get information for all countries of the world
	Then the status code should be 200

Scenario: check United Kingdom exists in the countries list
	Given I get information for all countries of the world
	Then United Kingdom exists in the list of countries