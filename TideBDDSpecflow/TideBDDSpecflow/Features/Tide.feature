Feature: Tide.Com Web Application 

for users to search products, shop products

@Language
Scenario:verify Language Change
	Given Load the website 
	And user click on language
	When user select language 
	Then websites language changed

@Shop
Scenario:Shop Product 
     Given Lunch the tide website
	 And hover mouse pointer on the shop product
	 When click on pacs  product  
	 Then result for pacs product displayed

@Commitment 
 Scenario: Our Commitment
 Given Open browser and open Website
 And hover mouse pointer on the our commitment
 When click on our ambition 
 Then our ambtion displayed

 @Wash
 Scenario: Wash Clothe
 Given Open  The Website
 And  hover mouse pointer on the how to wash clothes 
 When click on how to remove stains 
 Then Information for How to remove stain dispalyed

 @Coupns
 Scenario:  Coupons
 Given open the web
 And click on Coupons and rewards
 When click on save now 
 Then page redirected on log in page

 @livechat
 Scenario: Live chat
 Given Open  the Tide Website
 When Click on Live Chat
 Then Page redirected on Live chat page

 @Contact
 Scenario: Contact us
 Given Open the Tidecom website 
 When Click on contact us 
 Then Contact option displayed

 @SearchBox
  Scenario:verify search product 
 Given load the tidecom website
 And Enter the product name in the search box 
 When click on the search icon 
 Then result for Searched product displayed 

 @WhatsNewFeature
 Scenario: Whats new 
 Given Open the tide web
 When click on Whats new 
 Then Tide Program Displayed

 @FindRetailer
 Scenario: Find Retailer
 Given Load the tide Website
 And Hover Mouse pointer over Shop Product
 When  Click on Pacs from dropdown
 And click on Find Retailer Enter City name and click on search icon
 Then Near Retailer displayed  








