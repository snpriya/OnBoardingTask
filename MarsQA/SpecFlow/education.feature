Feature: MarsQAFeature1
Short summary of the feature
i logged into marsqa portal
Here I added feature for language,certificate(add,update,delete)for profile details, seller details
Feature: marsQAFeature
@CreateEducation
Scenario:1-1 Create Education
	Given I logged up and go to education page
	When I create a new education record '<country>' '<university>' '<coursetitle>' '<degree>' '<year>'
	Then The  new record  is created sucessfully '<country>' '<university>' '<coursetitle>' '<degree>' '<year>'
	Examples: 
	| country | university      | coursetitle | degree           | year |
	| India   | Anna university | B.Sc    | Computer Science | 2014 |
	@Edit
Scenario Outline:1-2 Edit education
    Given I logged up and go to education page
	When I update '<country>' '<university>' '<coursetitle>' '<degree>' '<year>' in existing education record
    Then The record is updated successfully '<country>' '<university>' '<coursetitle>' '<degree>' '<year>'
 Examples: 
 | country   | university          | coursetitle | degree  | year |
 | Australia | Victoria University | B.Sc        | Maths |  2017 |
 
 @Delete
 Scenario Outline:1-3 Delete  education
 Given I logged up and go to education page
  When I deleted the existing records using'<degree>' .
 Then The education is deleted Successfully'<degree>'
 
    