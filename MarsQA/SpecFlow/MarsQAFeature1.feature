Feature: MarsQAFeature1
Short summary of the feature
i logged into marsqa portal
Here I added feature for language,certificate(add,update,delete)for profile details, seller details
Feature: marsQAFeature
@CreateEducation
Scenario:1-1 Create Education
	Given I logged up and navigate to education page
	
	When I create a new education
	Then The  new record created sucessfully
	@Edit
Scenario Outline:1-2 Edit education
    Given I logged up and navigate to education page
	When I update '<degree>' in existing education record
    Then The record is updated
 Examples: 
 | degree    |
 | Chemistry |
 | maths     |
 @Delete
 Scenario Outline:1-3 Delete  education
 Given I logged up and navigate to education page
  When I deleted the existing records .
 Then The education deleted Successfully
 @createcertificate
 Scenario Outline:2-1 CreateCertification
	Given I logged up and navigate to certification page
	When I create a new Certification
	Then The new certificate record created sucessfully
	@Edit
Scenario Outline:2-2 Edit the certification with valid credentials
   	Given I logged up and navigate to certification page
    When I update '<certificate>' on an existing certificate record
    Then The record is update
    Examples:     
    | certificate |
    | Tester      |
    | BI          |
 @Delete
 Scenario Outline:2-3 Delete the certification
    Given  I logged up and navigate to certification page
    When  I deleting exist records using '<certificate>'
    Then  The certification deleted Successfully

    @Addlanguage
Scenario:3-1  Add Language
	Given I logged up and navigate to Language page
	When I add a Language
	Then The  new record added sucessfully
	@EditLanguage
Scenario Outline:3-2 Edit the Language with valid credentials
   
    Given I logged up and navigate to Language page
    
    When I update '<language>','<level>' on an existing education record
    Then The record is update '<language>','<level>'
    Examples:   
    | language | level  |
    | English  | Fluent |
    @DeleteLanguage
 Scenario Outline:3-3 Delete the Language
 Given I logged up and navigate to Language page
  When I deleted the existing records 
 Then The language deleted Successfully
