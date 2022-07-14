Feature: Language

A short summary of the feature

@Addlanguage
Scenario:1 Add Language
	Given I logged up and go to Language page
	When I add a Language to language page '<language>' '<languagelevel>'
	Then The  new record  is added sucessfully '<language>' '<languagelevel>'
    Examples: 
    | language | languagelevel |
    | Hindi    | Basic         |
	@EditLanguage
Scenario Outline:2 Edit the Language with valid credentials
   
    Given I logged up and go to Language page
    
    When I update '<language>','<languagelevel>' on an existing education records
    Then The record is updated '<language>','<languagelevel>'
    Examples:   
    | language  | languagelevel |
    | malayalam | Basic         |
    @DeleteLanguage
 Scenario Outline:3 Delete the Language
 Given I logged up and go to Language page
  When I deleted the existing records using '<language>'
 Then The language deleted Successfully using '<language>'
