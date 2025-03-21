namespace ClassesPract.Class;

public class Calculator
{
    public int DecToBin(int dec)
    {
        return int.Parse(Convert.ToString(dec, 2));
    }
    public int BinToDec(int bin)
    {
        return Convert.ToInt32(bin.ToString(), 2);
    }
    public int DecToOct(int dec)
    {
        return int.Parse(Convert.ToString(dec, 8));
    }
    public int OctToDec(int oct)
    {
        return Convert.ToInt32(oct.ToString(), 8);
    }
    public int DecToHex(int dec)
    {
        return int.Parse(Convert.ToString(dec, 16));
    }
    public int HexToDec(int hex)
    {
        return Convert.ToInt32(hex.ToString(), 16);
    }
    public int BinToOct(int bin)
    {
        return DecToOct(BinToDec(bin));
    }
    public int OctToBin(int oct)
    {
        return DecToBin(OctToDec(oct));
    }
}