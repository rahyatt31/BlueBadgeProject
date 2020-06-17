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


There are two ways to obtain the code. You can download the project as a zip file or clone the repository. If you 
choose to download the zip file you can then expand it in your choosen location. The prefered method of obtaining
the project is by using the command-line Git utility. There is a clip-board friendly Git link right next to the 
download option. That Git link will allow you to clone the repository using the command line. Either way you obtain
the project you can either double click on the solution file in the main directory or open it within Visual Studio. 


   Once you have the project open there are two aspects to this project. There is an API which accessible using the Postman
utility or through the launch page in your browser. Through this API you can view, delete, edit, and create players. Each player has a list
of realistic stats. Each player is also assigned to a team which is completely customizable. 

   The console application is a proof of concept that mirrors our api Player/Team structure and allows you to create a fantasy matchup between the teams of your choice.  


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

### Web App 
  Our API is accessible directly through the web browser. When the program launches our custom splash screen should appear in the browser which allows you to View, Create, Edit and Delete your Players, Player Stats, Teams, and Games. Everything you have done in postman is accessible through this website - which provides an easy way to interface with our API without any extra software.  



### Console App

When our application starts you will also see a console window open and the Football Manager app load up. This application gives you the opportunity to create a fantasy matchup between the Colts and Jaguars. It maintains it's own player and team data however it is  Each team will get 4 series of plays to try to score the most points and win the game. Play outcomes are random, however the skill of the players influences the liklihood of success.  

## License

This is a student project. Take it - change it - make it yours! 

## Special Thanks!

* Brantley Heath
* Robbie Hyatt
* Everyone @ Eleven Fifty Academy 


Sources:

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
