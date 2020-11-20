Feature: SpecFlowFeature1
	As a User
	 In order to use Giftrete Website
	 I will need to first register

@mytag
Scenario: Valid Login 
Given that the user navigate to "https://opensource-demo.orangehrmlive.com/" 
	And user enter username "Admin"
	And user enter password "admin123"
	When  user click the login button
	Then the user will be login


	@secondstage
	Scenario:  Invalid Password Login Test
	And user enter an invalid password "admin12345"

	@thirdstage
	Scenario: Invalid username Login test
	And user enter invalid username "Admin123"

	

	@fourthstage
	Scenario: entering blank username and password
	And user enter blank username " "
	And user enter blank password " "

	@fifthstage 
	Scenario: Verify notification
	And user verify the notification


	@sixthstage
	Scenario: Validate the Enter Key
	And user enter username "Admin"
	And user enter password "admin123"
	When user press the enter key
	Then user will be able to login successfully

	@seventhstage
	Scenario: Enter alphanumeric characted
	And user enter username "Admin#123"
	And user enter password "admin123#"




