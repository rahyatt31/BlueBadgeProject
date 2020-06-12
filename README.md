# Football Manager

This project utilizes c#, asp.net, n-tier architecture, and WebAPI which allows for the fast development and testing of a new WebAPI protocol. Our API allows you to create players. Each player has their own stats. 
All players can be assigned to teams. Teams can also face eachother in a fantasy match-up game to determine the stronger team and the winner. This is a great
program that has introduced us to a lot of new concepts such as RESTful to ensure programs are cross platform and make sense.  


### Prereqisites
  This project was built using:
* [Visual Studio 2019](https://visualstudio.microsoft.com/vs/) - Visual Studio 2019 Community. 
* [Postman](https://www.postman.com/downloads//) - Postman Api Development Environment
* [Github](https://github.com/) - Code Repository, Team collaboration, where our project is hosted. 

## Getting Started

Our project is located @ FinalGitHubLink and @ FinalCommentedGitHubLink
One version of the project has been commented. The other version is the same but without comments. 

There are two ways to obtain the code. You can download the project as a zip file or clone the repository. If you 
choose to download the zip file you can then expand it in your choosen location. The prefered method of obtaining
the project is by using the command-line Git utility. There is a clip-board friendly Git link right next to the 
download option. That Git link will allow you to clone the repository using the command line. Either way you obtain
the project you can either double click on the solution file in the main directory or open it within Visual Studio. 


   Once you have the project open there are two aspects to this project. There is an API which accessible using the Postman
utility that has been linked above. Through this API you can view, delete, edit, and create players. Each player has a list
of realistic stats. Each player is also assigned to a team which is also completely customizable. 

   These teams are then accessible in the console aspect of our application. You are able to play a simulated real game between
the teams using real stats. 


### API Endpoints

You will know the API is up and running when your web browser opens with the custom Football Manager splash screen

 One you register and receive a token you have access to the API. 
 
 Players can be created with the following attributes:
 
 
Api/Player - These are the base stats every player needs.
```
PlayerFirstName PlayerLastName 
PlayerPosition PlayerJerseyNumber
PlayerHeightByINches PlayerWeightByPounds  
TeamID
```

Api/PlayerStats - these extended stats apply to all players as well. 

```
PassingYards PassingTouchdowns 
InterceptionThrown RushingYards
RushingAttempts RushingTouchDowns 
ReceivingYards Catches
ReceivingTouchDowns Fumbles 
Tackles Sacks Interceptions
ForcedFumbles FumbleRecovery 
Safety BlockedKick
ReturnTouchDown
```



### Console App

In order to run the Console app you will need to right click on the GamePlayer in the solution explorer and click on 
Select Focus.



### Break down into end to end tests

Explain what these tests test and why

```
Give an example
```


## License

This is a student project. Take it - change it - make it yours! 

## Acknowledgments

* Brantley Heath
* Robbie Hyatt
* Everyone @ Eleven Fifty Academy 
See also the list of [contributors](https://github.com/your/project/contributors) who participated in this project.

ReadMe References:

DateTime Properties
https://stackoverflow.com/questions/8043816/using-datetime-properties-in-code-first-entity-framework-and-sql-server

RANGE Attribute
https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.rangeattribute?view=netcore-3.1

Error with Using MAXLENGTH on a string vs. an int
https://stackoverflow.com/questions/19204979/system-invalidcastexception-unable-to-cast-object-of-type-system-int32-to-typ

One-Many and One-One Relationships
https://www.entityframeworktutorial.net/efcore/configure-one-to-one-relationship-using-fluent-api-in-ef-core.aspx

Using the same TYPE for Foreign Keys and IDs
https://entityframework.net/knowledge-base/50660643/error-in-entity-framework-relationships-mapping

SQL connecting to Console App
https://support.microsoft.com/en-us/help/314145/how-to-populate-a-dataset-object-from-a-database-by-using-visual-c-net

Adding a special formatting package for ASYNC 
https://stackoverflow.com/questions/14520762/system-net-http-httpcontent-does-not-contain-a-definition-for-readasasync-an

Adding API Documentation
https://docs.microsoft.com/en-us/aspnet/web-api/overview/getting-started-with-aspnet-web-api/creating-api-help-pages

Roslyn Error Fix
https://stackoverflow.com/questions/32780315/could-not-find-a-part-of-the-path-bin-roslyn-csc-exe

Watch LINQ videos

