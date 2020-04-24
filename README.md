 AutomationCodingChallenge
 
 # Runnning Application
Used Following Libraries via Nu Get Package Manager VS :

- OpenQA.Selenium.Support
- Selenium Core
- Selenium Chrome Driver
- NUnit Testing Framework
- Nunit Test adapter


Website used :  https://www.booking.com/ 

Test Criteria
The website http://booking.com have extended their search filters with some new options.
The new options are:
•	Star Rating
•	Spa/wellness centre

Challenge
Write a set of tests scripts using Selenium webdriver and C# language.
Use the the test criteria provided and appropriate testing frameworks

Test Data included

| Location  | No: of Guests |Rooms| Selection Filter  | Hotel Name           | Is Listed |
| --------- | ------------- |-----|------------------ |--------------------- |---------- |
| Limerick  |       2       |  1  |     Sauna         |Limerick Strand Hotel |   True    |
| Limerick  |       5       |  6  |     Sauna         |Limerick Strand Hotel |   True    |
| Limerick  |       25      |  20 |     5 Star        |   The Savoy Hotel    |   True    |
| Limerick  |       3       |  2  |     5 Star        |George Limerick Hotel |   False   |
| Limerick  |       2       |  1  |     5 Star        |   The Savoy Hotel    |   True    |
| Limerick  |       5       |  6  |     Sauna         |George Limerick Hotel |   True    |
| Limerick  |       2       |  1  |     5 Star        |George Limerick Hotel |   False   |







