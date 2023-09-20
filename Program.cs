// See https://aka.ms/new-console-template for more information
Console.WriteLine("===Start a new game==\nType 'Start' or 'S' to play ");

string startGame = Console.ReadLine()!;

if(!(startGame.Equals("Start", StringComparison.OrdinalIgnoreCase) || startGame.Equals("S", StringComparison.OrdinalIgnoreCase))){
     Console.WriteLine("Oops enter the right input");
     return;
}


Random rand = new();

int dice1 = rand.Next(1,7);
int dice2 = rand.Next(1,7);
int dice3 = rand.Next(1,7);
int originalScore = dice1 + dice2 + dice3;
int doublePoint = 2;
int triplePoint = 3;
int totalPoint =0;

Console.WriteLine($"diceone {dice1} \ndicetwo {dice2} \ndicethree{dice3}");



if(dice1 == dice2 && dice2 == dice3){
    Console.WriteLine("you scored a triple point");
    totalPoint = originalScore + triplePoint;
    System.Console.WriteLine($"You scored {totalPoint} points ");

}

else if (dice1 == dice2 || dice2 ==dice3 || dice1 == dice3)
{Console.WriteLine("you scored a double point");
        totalPoint = originalScore + doublePoint;
 System.Console.WriteLine($"You scored {totalPoint} points ");
}

if (totalPoint >= 10 && totalPoint <= 13)
{
   System.Console.WriteLine("congratulations you win a ballon"); 
   System.Console.WriteLine(totalPoint);
   
}

else if (totalPoint >= 18 && totalPoint <=20){
System.Console.WriteLine("You won a Silverbird ticket");
System.Console.WriteLine(totalPoint);
System.Console.WriteLine($"You scored {totalPoint} points ");
}

else if (totalPoint >= 22 && totalPoint <=24){
System.Console.WriteLine("You receive all the items");
System.Console.WriteLine(totalPoint);
System.Console.WriteLine($"You scored {totalPoint} points ");
}

else if (totalPoint == 21){
System.Console.WriteLine("You received a samsung a24");
System.Console.WriteLine(totalPoint);
System.Console.WriteLine($"You scored {totalPoint} points ");
}

else
{
    System.Console.WriteLine("try again");
    System.Console.WriteLine($"You scored {totalPoint} points ");
}