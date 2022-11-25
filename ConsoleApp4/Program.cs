using ConsoleApp4.Utility;

double convertToAzn(CurrencyEnum currency,double amount)
{
    switch (currency)
    {
        case CurrencyEnum.Usd:
            return amount* 0.59;
        case CurrencyEnum.Eur:
            return amount * 0.53;
        case CurrencyEnum.TRY:
            return amount * 8.73;
        case CurrencyEnum.Rub:
            return amount * 52.21;
        default:
            return -1;
    }
}

Console.WriteLine(convertToAzn(CurrencyEnum.Eur,5));

