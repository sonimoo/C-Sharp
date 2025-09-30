using System;

// В ассортименте есть 3 товара: напиток, первое и второе. 
// У каждого из них разные цены (например: 10, 20, 30).
// а что получается это цена за грамм?! (устраивает, валюта корейские воны курс 1 к 0,012 лею))))

PriceList price = new()
{
    drinkPrice = 10,
    firstPrice = 20,
    secondPrice = 30
};

ClientChoice client1 = new()
{
    drinkGrams = 100,
    firstGrams = 0,
    secondGrams = 250
};


ClientChoice client2 = new()
{
    drinkGrams = 0,
    firstGrams = 300,
    secondGrams = 0
};

int client1_total = CustomerTotal(price, client1);
Console.WriteLine(client1_total);

int client2_total = CustomerTotal(price, client2);
Console.WriteLine(client2_total);

static int CustomerTotal(PriceList prices, ClientChoice choices)
{
    int client_drink = choices.drinkGrams * prices.drinkPrice;
    int client_first = choices.firstGrams * prices.firstPrice;
    int client_second = choices.secondGrams * prices.secondPrice;
    int client_total = client_drink + client_first + client_second;
    return client_total;
}

struct PriceList
{
    public int drinkPrice;
    public int firstPrice;
    public int secondPrice;
}

struct ClientChoice
{
    public int drinkGrams;
    public int firstGrams;
    public int secondGrams;
}