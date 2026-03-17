namespace Decorator;

public class VampirismEnchantDecorator : WeaponDecorator
{
    public VampirismEnchantDecorator(IWeapon decoratedWeapon) : base(decoratedWeapon)
    {
    }

    public override string GetDescription()
    {
        Console.WriteLine("Vampirism Enchanted");
        return _decoratedWeapon.GetDescription() + " Вампиризм";
    }

    public override int GetDamage()
    {
        return _decoratedWeapon.GetDamage() + -2;
    }

    public override decimal GetPrice()
    {
        return _decoratedWeapon.GetPrice() * 2;
    }
}