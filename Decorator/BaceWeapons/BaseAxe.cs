namespace Decorator;

public class BaseAxe : IWeapon
{
    private string _name;
    private int _baseDamage;
    private int _basePrice;

    public BaseAxe(string name, int baseDamage, int basePrice)
    {
        _name = name;
        _baseDamage = baseDamage;
        _basePrice = basePrice;
    }

    public string GetDescription()
    {
        return _name;
    }

    public int GetDamage()
    {
        return _baseDamage;
    }

    public decimal GetPrice()
    {
        return _basePrice;
    }
}