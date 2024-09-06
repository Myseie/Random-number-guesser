Random rnd = new Random();

int numb = rnd.Next(1, 101);

int guess = 0; 
int guesscounter = 0;
while ( guess != numb) { 
Console.Write("Gissa ett tal mellan 1-100 : ");

string input = Console.ReadLine();

guess = int.Parse(input);

    guesscounter++;

if (guess > numb)
{
    Console.WriteLine("Du gissa för högt gissa lägre");

}else if (guess < numb)
{
    Console.WriteLine("Du gissa för lågt gissa högre");
}
else
{
    Console.WriteLine("Du gissa rätt grattis!");
        Console.WriteLine("Antalet gissade gånger : " +  guesscounter);
    }
}
