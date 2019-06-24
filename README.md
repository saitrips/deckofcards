# deckofcards
Implement shuffle and dealonecard functionality in poker style cards game


Folder Contains : Deckofcards Project solution 
				          Deckofcards_EXECUTABLE : I build the project locally and copied the executable ready to use.



How to Build the project:

  -Minimum .NET framework required building and running this application: .NET Framework 4.5
  
  -Open the Command Prompt window.
  -Change the directory to the one that contains MSBuild.exe:   If you have .NET v4 installed   cmd: cd C:\Windows\Microsoft.NET\Framework\v4.0.30319
  -Type the below command-line statement to build the release build  :

MSBuild.exe C:\Folder project is cloned\DeckOfCards\DeckOfCards.sln /t:Rebuild /p:Configuration=Release /p:Platform="any cpu" 
            /p:OutputPath=c:\mydir

  example:

MSBuild.exe C:\Users\sedupuganti\Desktop\DeckOfCards\DeckOfCards.sln  /t:Rebuild /p:Configuration=Release /p:Platform="any cpu" 
            /p:OutputPath=C:\mydir


How to Run the program notes:

  -Open the Command Prompt window.
  -Change the directory to the one that contains the application tool exe: cmd: cd C:\mydir

  -Command to run   : DeckOfCards.exe


Unit Test Project:

   -I developed this project in Test Driven Approach. I created a simple test cases to test all functions defined in  problem statement.
   -to run the Unit Test. Open the DeckOfCards.sln project in Visual Studio 2015 and above, go to Test Menu-->Run-->All Tests

