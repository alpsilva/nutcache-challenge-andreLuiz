# nutcache-challenge-andreLuiz
Technical Challenge: Create a Web Api to facilitate people management.

# How do I run this?
## Using Visual Studio 2019 Community
1. Import the "NutcachePeopleManagement" Solution;
2. Make sure that the solution startup is set to "multiple startup projects" and launching the "NutcachePeopleManagement" API and "NutcachePMGUI" desktop client.
3. Press ctrl + f5 to run the API and launch the desktop client;
4. In your browser, a page should open with the following url: https://localhost:44352/api/people
5. In the desktop client you can add new Employees, remove them from the list or edit them. The main page also lists all registered employees.
Note: I was unable to add buttons to each row that would make it easier to delete or update, due to a confusion with the limit date for this assignament (because it was in the MM/dd/YYYY format, that is different from the one commonly used here, and also health issues. I know how to easily do this in angular, but with the issues stated, i wasn't able to complete this requirement. Instead, you just need to copy and paste the employee ID in the textbox and click the button corresponding to the feature you want to use).

You can test the API alone using postman or your preferred method of sending web requests.  
Here are some example requests:

Register a new Person  
POST https://localhost:44352/api/People  
body: {
  "name":"André Luiz",
  "birthDate":"1998-07-16T00:00Z",
  "gender":"Male",
  "email":"a@cin.ufpe.br",
  "CPF":"123",
  "startDate":"2021-10-10T00:00Z",
  "Team":"Backend"
}

Returns a list of all registered people  
GET https://localhost:44352/api/People  

Returns the Person whose Id is 1  
GET https://localhost:44352/api/People/1  

Updates the Person whose Id is 1 data with the new data  
PUT https://localhost:44352/api/People/1  
body: {
  "id":"1",
  "name":"André Luiz",
  "birthDate":"1998-07-16T00:00Z",
  "gender":"Male",
  "email":"alps2@cin.ufpe.br",
  "CPF":"123",
  "startDate":"2021-10-10T00:00Z",
  "Team":"Backend"
}

Removes the Person whose Id is 1  
DELETE https://localhost:44352/api/People/1  
