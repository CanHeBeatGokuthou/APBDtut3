# APBDtut3
At first I tried to work diffrentlly with this project. I decided to create a sepearet container that would hold diffrent SpecialRecords, created based on information like user,equipment,id etc.
Unfortunatly I could't see how to finish this version, I tried to make it more for input from the user but I bumped on many different problems that were simply too complicated for to finish.
I decided also to simplyfie the classes by seperating them but when trying to combine it all I decided that it's not really neccessary and I put some information about time managing between two classes(RentalService,SpecialRecor)
I don't think that I gave my best in this project but I was beat by simple lack of time.
Here is explenation what works how:
1.I created an absteact classes(User,Equipment) so that I have easy "skeleton" for creation of individual item/person
2.Each Person and Equipment has it's own specyfic field but it's only because of demand in the task sheet
3.I created a sepreate RadnomIdGenerator class that generates unique Id for item or user using DateTime and Random type variable
4.When I had all specyfic classes for items and users I created a SpecialRecord class(It was soupoused to be a class that would work with my SpecialContainer class but yeah I couldn't make it work)
5.RentalService is the class where the whole magic is happenning:
  1) One of the most important part of the code is .FirstOrDefault() method it does most of the heavy work in the code, it's used in order to search a container and return the matching element based on expresion in the           brackets, I used it to simplie find what I want from the container instaed of iterating with for example foreach loop .
  2) I used List for staring data because they are the most basic containers and are easy to work with
  3) Rest of the code is preaty much selfexplaynatory. I use "throw Exception" with my class rentalException in case I can't find something, or use if statement to check if null
6.Class Program is my "main" class inside it I give a preapered screep of diffrent cases that were wanted in the task file. All is formated for easy read in the console. Since i used exceptions to comunicate with the user use of try-catch was neccesarry. They allowed for smoth renting of equipment and catchi if there was a problem with it.
