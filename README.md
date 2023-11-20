# Virus Definition Api Test - Lead Developer

***Time to Complete - 1 Hour***

*You do not have to finish the api or even have it compile!*

Below are 2 stories that form part of the requirements to create an api that manages virus definitions. They are written in a way that should be understandable by the end user, developer and QA. Consideration should be taken for testability!

This empty ASP.NET Core 3.1 project starts you off with some basic contracts such as an Interface for a repository data store and model class for the Virus Definition.

At the end of the hour we would like you to present and explain your reasons as to why you have designed it the way you have and also where you would see the next steps going, if you were given more time. Good luck!

## Story 1

***As a Threat Researcher***  
***I would like to store Virus Definitions***  
***So that I have a centralized datastore to manage Viruses***  

### Acceptance Criteria

Given a new valid virus definition  
When I call the api to add  
Then it will successfully insert the Virus definition in the data store  

Given an empty Virus definition name or signature  
When I call the api to add or update  
Then it will return a bad request  

Given an existing valid virus definition  
When I call the api to update  
Then it will successfully update the virus Definition in the data store  
And not behave any differently if called multiple times with the same data  

## Story 2

***As a Threat Researcher***  
***I would like to look up Virus Definitions from a data store***  
***So that I have a centralized way of looking up Viruses***  

### Acceptance Criteria

Given a valid virus definition identifier that exists  
When I call the api to retrieve the virus definition  
Then I successfully receive the virus definition  

Given a valid virus definition identifier that does not exist  
When I call the api to retrieve the virus definition  
Then it will return not found  

Given an invalid virus identifier  
When I call the api to retrieve the virus definition  
Then it will return a bad request  


