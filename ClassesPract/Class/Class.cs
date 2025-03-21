using System.Text.RegularExpressions;

namespace ClassesPract.Class;

public class CreditCard()
{
    private string cardNumber;
    private string cardHolder;
    private string cvc;
    private string expiryDate;

    public string CardNumber
    {
        get => cardNumber;
        set
        {
            if (!Regex.IsMatch(value, @"^\d{16}$"))
            {
                throw new ArgumentException("Card number must be 16 digits long");
            }
            cardNumber = value;
        }
    }

    public string CVC
    {
        get => cvc;
        set
        {
            if (!Regex.IsMatch(value, @"^\d{3}$"))
            {
                throw new ArgumentException("CVC must be 3 digits long");
            }
            cvc = value;
        }
    }

    public string ExpiryDate
    {
        get => expiryDate;
        set 
        {
            if (!Regex.IsMatch(value, @"^\d{2}/\d{2}$"))
            {
                throw new ArgumentException("Expiry date must be in the format MM/YY");
            }
            expiryDate = value;
        }
    }

    public string CardHolder
    {
        get => cardHolder;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Card holder cannot be empty");
            }
            cardHolder = value;
        }
    }

    public CreditCard(string cardNumber, string cardHolder, string cvc, string expiryDate) : this()
    {
        CardNumber = cardNumber;
        CardHolder = cardHolder;
        CVC = cvc;
        ExpiryDate = expiryDate;
    }
    public override string ToString()
    {
        return $"Card Number: {CardNumber}\nCard Holder: {CardHolder}\nCVC: {CVC}\nExpiry Date: {ExpiryDate}";
    }
        
}