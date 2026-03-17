namespace Decorator;

public class SharpeningDecorator : WeaponDecorator
{
    public SharpeningDecorator(IWeapon decoratedWeapon) : base(decoratedWeapon)
    {
        _decoratedWeapon = decoratedWeapon;
    }

    public override string GetDescription()
    {
        return _decoratedWeapon.GetDescription() + " Заточено";
    }

    public override int GetDamage()
    {
        return _decoratedWeapon.GetDamage() + 5;
    }

    public override decimal GetPrice()
    {
        decimal d = _decoratedWeapon.GetPrice();
        return d + d/100*20;
    }
}