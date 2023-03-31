# Digital-Bullet-Journal
This digital bullet journal created for my Code Louisville project will allow the user to utilize basic journal functions including writing to a text entry and viewing
it and populating a list to create a habit tracker.

For my first ever program I decided to create the barebones of a bullet journal that can be utilized in a console app. Initially my goals for the project were a bit more
lofty than my skills could provide me with, but ultimately I have created something wholly functional, which I am very pleased about. The main functions of the program
are to write to and view a text journal and write to and view a habit tracker. The journal entry is fairly simple; the user simply writes to a single text file and is able
to add to it by line for readability. It is able to be viewed in the program. The habit tracker has the user input the name of the individual habit and the user can store a 
week's worth of habits at a time, with the ability to overwrite the file to start the week anew. I stuck with only a week in order to maintain the base functionality
without sacrificing too much by way of a cluttered console app. 

For my features I chose these: 
-Implement a “master loop” console application where the user can repeatedly enter
commands/perform actions, including choosing to exit the program (used in the main program, BuJo.cs)

-Create an additional class which inherits one or more properties from its parent (The HabitTracker class inherits from the Habits class to populate a list of habits,
which become an object containing a string and a dictionary)

-Create a dictionary or list, populate it with several values, retrieve at least one value, and
use it in your program (I created a dictionary to keep track of weekdays and the corresponding values. It is populated initially with the keys and the user input then
determines the value. The entire dicitonary is then used in the Habits object to be printed to the console)

-Read data from an external file, such as text, JSON, CSV, etc and use that data in your
application (data is read from text files to display the journal entry and to display the current habit tracker on demand)


To run the application, one should only need pull the file and run via Visual Studio 2022. 
