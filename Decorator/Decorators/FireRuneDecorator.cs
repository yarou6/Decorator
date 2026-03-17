namespace Decorator;

public class FireRuneDecorator : WeaponDecorator
{
    public FireRuneDecorator(IWeapon decoratedWeapon) : base(decoratedWeapon)
    {
        _decoratedWeapon = decoratedWeapon;
    }

    public override string GetDescription()
    {
        return _decoratedWeapon.GetDescription() + " Огненная руна";
    }

    public override int GetDamage()
    {
        return _decoratedWeapon.GetDamage() + 10;
    }

    public override decimal GetPrice()
    {
        return _decoratedWeapon.GetPrice() + 100;
    }
}