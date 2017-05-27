# BoardGameBuddy
Final Product Discription - Basic Functions
-	Light Weight Board Game Collection Web App
-	Build and View you Game Library
-	View Title Sqecific Information.
-	Query/Sort Library based on Game attributes. ex.(display 2 player games, under 45mins.)
-	Have multi user log-ins. Login/Password
-	Store all this in a database in a server(web app)
-	Use boardgamegeek data(think imdb of Boardgames) and their api to pull desiered game data. 
-	(search for Title, pull data from BGG, store in database on server) check legallity???

More Features outside Collection Management/Query(Find a Game To Play)/Sorting

Score Tracker
* GUI score tracker, add player names, calculate score (we make a calculator?)
* Less likely - Make Game specific score trackers - Visual Themes or simply more tailored caluclation method. Or modular trackers
Game Play Logs
* Who won last time we played Murder Kings? Check the game specific Play Logs.
* Current Champion - Math out individual play counts, wins, losses, etc. to crown a reigning Champion
* Save Player Names and Play Logs.  
* View Player specific logs.(wins/losses)
* The Score Tracker will Upload info to Play Logs automatically

Game Notes (list important notes you have for playing)
* Contested Rules / Rule Reminders / House Rules
* Quick Start Guide (play phases, action orders etc.

Other Features that Could be Implemented
* First Player Randomizer (built into Score tracker?)
* Dice (game use / dispute setteler) why not?
* House Glass / Timers
* Save RuleBook PDF to device for quick access (for other players to look at and ctrl F is great for searching rule books)

Theres a lot of features that could be implemented that are at least related or useful when playing a board game that could be added for learning purposes.  These all might not be super useful but still be good to make them?
	
!!!!!!!!current state!!!!!!!!!
views)
1. welcome page with link to Library view (list titles)
2. Library Page with links to detail views (shows game attributes)
3. navagation between them.
4. basic ass html

Data/Models/Repository)
1. BoardGame Model/class
2. Repository that creates an array of hard coded game titles and attributes.



Master Plan
Board Game Companion App.
Phase 1)
1. Game Library List: sorting, quereys
2. BoardGame - Displays info of specific Title( player ct, rating, play time,  play logging
            Game Libirary data hard coded.  Only one List/User.
            
Phase 2)            
1. Clean up HTML
2. Multi List/User log-ins?  Now idea how user log-ins work yet....could be too much too soon.
3. Add titles from drop down or search bank?   *Game info still hard coded.

Phase 3)
1.  Learn ****SQL**** and SQL .net intragretion. 
    Upload Game Titles to server.
    Search Server for title.
    Add to list from server.
    Save List to server.
    Probably some more user log-in stuff.  
    *****No idea how indepth or advanced this is.

Phase 4)
1. Board Game Geek API
    https://boardgamegeek.com/wiki/page/BGG_XML_API2
    This should tell me how to use BGG data from their servers?
    ****Know nothing about this******* with a api it shouldent be too hard?  Make direct calls to BGG servers instead of scraping
    Im not even sure I know is the line above has any validity or if its just what i think is the internet workings.
    
2. One BoardGameGeek api can be used to find titles......pull data
