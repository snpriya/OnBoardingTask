Feature: certificate

A short summary of the feature

@createcertificate
 Scenario Outline:1 CreateCertification
	Given I logged up and go to certification page
	When I create a new Certifications using '<certification>' '<from>' '<year>'
	Then The new certificate record added sucessfully'<certification>' '<from>' '<year>'
    Examples: 
    | certification | from             | year |
    | Test Analyst  | Industry Connect | 2017 |
	@Edit
Scenario Outline:2 Edit the certification with valid credentials
   	Given I logged up and go to certification page
    When I update '<certificate>' '<from>' '<year>' on an existing certificate record
    Then The record will be updated using '<certificate>' '<from>' '<year>'
    Examples:     
    | certificate | from  | year |
    | Tester       | ISTQB | 2007 |
    
 @Delete
 Scenario Outline:3 Delete the certification
    Given  I logged up and go to certification page
    When  I delete existing record using '<certificate>'
    Then  The existing certification deleted Successfully '<certificate>'
    Examples: 
    | certificate |
    | Tester      |
   