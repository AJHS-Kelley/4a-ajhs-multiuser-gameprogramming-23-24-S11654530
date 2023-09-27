// Ronald Durham, Program Template, v0.01
/*
Generate secret number from a defined range of numbers (i,e, 0-10 , 0-50, 0-100 )
Print game instructions including range and num. of guess allowed 
      Match == first player to score 3 points 
      Round == guessing a specific number, untill correct or no more attempts 
Ask the player what difficulty they want to play on 
Ask the player what their guess is.
Determine if the guess us correct or not
   If guess is correct{
     Tell them they have guessed correctly.
     Award the player a point
   } else {
    Tell them they are wrong.
    Tell Them if guess is too high or too low 
    Check to see if they have guesses remaining  }
   if guess remain: {
    allow player to guess again.
   } else { 
    CPU wins the round 
*/
using systems; 

namespace numberGuess 
{
 Class NumberGuess 
{


static void main(string[] args)
{
    int secretNumber = -1;
    int numGuesses = 0; // Number of guesses player is ALLOWED
    int numAttempts = 0;
    int playerScore = 0;
    int cpuScore = 0
    String difficulty = ""
    Int rangeMin = -1;
    int rangeMax = -1;
    Constole.WriteLine("Welcome to the Number Guess Game!\nYou will select a difficulty ") 
    Constole.WriteLine(" Easy Mode: Range is 0 - 10 with 4 guesses.\nNormal ")

    // DIFFICULTY SELECTION
    Console.WriteLine("Please type easy, normal, or hand and press enter ") 
    if (difficulty == "easy") {
        rangeMin = 0; 
        rangeMin = 10;
        numGuesses = 4;


    }else if (NORMAL MODE) {
        // code to run.
    }else if ( HARD MODE) {
        // code to run.
    } else { 
         // Code to run if no difficulty is selected.
    } 
    Console.WriteLine("minimum: " + rangeMin);
	Console.WriteLine("Maximum: " + rangeMax);
	Console.Writeline("Num, Guesses:" + numGuesses);

   //START THE MATCH!
   While (playerscore != 3 && cpuScore ! = 3) {
	   // Any code you went yo run BEFORE each round 
	   
	   
	   //START EACH ROUND 
	   for (int i = 0; i < numGuesses ; i++) {
          // Code to guess number goes here

.
}
}

