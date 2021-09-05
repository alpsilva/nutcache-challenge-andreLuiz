# nutcache-challenge-andreLuiz
Technical Challenge: Create a Web Api to facilitate people management.

# How do I run this?
## Using Visual Studio 2019 Community
1. Import the "NutcachePeopleManagement" API project;
2. Press alt + f5 to run the API.
3. In your browser, go to https://localhost:44352/api/people
4. It should show an empty list of registered people.

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
