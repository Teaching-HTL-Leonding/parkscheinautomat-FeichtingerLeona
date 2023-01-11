double coins = 0;
int coin = 0;
int parkingMinutes = 0;
int parkingHours = 0;
double donation = 0;
int euro = 0;
double cent = 0;


void PrintWelcome()
{
    System.Console.WriteLine("Parkscheinautomat mit Mindestparkdauer 30 Min und Höchstparkdauer 1:30 Stunden");
    System.Console.WriteLine("Tarif pro Stunde: 1 Euro");
    System.Console.WriteLine("Zulässige Münzen: 50 (Cents), 10 (Cents), 20 (Cents), 50 (Cents), 1 (Euro), 2 (Euro)");
    System.Console.WriteLine("Parkschein drucken mit d oder D");
}
void EnterCoins()
{
    System.Console.WriteLine("Please enter your coins");
    string entercoins = Console.ReadLine()!;
    bool readyWithEnteringCoins = false;

    do
    {
        if (entercoins == "d" || entercoins == "D")
        {
            if (coins > 0.5)
            {
                System.Console.WriteLine("Nicht genug Geld eingeworfen. Bitte Werfen sie mehr ein");
            }
            else
            {
                readyWithEnteringCoins = true;
            }
            if (coins > 1.5)
            {
                readyWithEnteringCoins = true;
            }

        }
        else if (entercoins == "1" || entercoins == "2" || entercoins == "5" || entercoins == "10" || entercoins == "20" || entercoins == "50")
        {
            coin = int.Parse(entercoins);
            if (coin < 2)
            {
                coins += coin / 100;
                AddParkingTime();
            }
            else
            {
                coins += coin;
                AddParkingTime();
            }
        }
        else
        {
            System.Console.WriteLine("Falsche Münze");
        }


    }
    while (!(readyWithEnteringCoins));
}
void AddParkingTime()
{
    if (coin == 1)
    {
        parkingHours++;
    }
    else if (coin == 2)
    {
        parkingHours += 2;
    }
    else if (coin == 5)
    {
        parkingMinutes += 3;
    }
    else if (coin == 10)
    {
        parkingMinutes += 6;
    }
    else if (coin == 520)
    {
        parkingMinutes += 12;
    }
    else if (coin == 50)
    {
        parkingMinutes += 30;
    }
    System.Console.WriteLine($"Bisherige Parkzeit {parkingHours}:{parkingMinutes}");
}
void PrintParktime()
{
    System.Console.WriteLine($"Parkzeit {parkingHours}:{parkingMinutes}");
}
void PrintDonation()
{
    donation = coins - 1.5;
    do
    {
        if (donation >= 1)
        {
            euro += 1;
            donation -= 1;
        }
    }
    while (donation >= 1);
    cent = donation / 100;
    System.Console.WriteLine($"Du wirst {euro} Euro und {cent} Cent spenden ");
}

PrintWelcome();
EnterCoins();
PrintParktime();
PrintDonation();
