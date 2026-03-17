namespace Decorator;

public abstract class WeaponDecorator : IWeapon
{
    protected IWeapon _decoratedWeapon;

    protected WeaponDecorator(IWeapon decoratedWeapon)
    {
        _decoratedWeapon = decoratedWeapon;
    }

    public virtual string GetDescription()
    {
        return _decoratedWeapon.GetDescription();
    }

    public virtual int GetDamage()
    {
        return _decoratedWeapon.GetDamage();
    }

    public virtual decimal GetPrice()
    {
        return _decoratedWeapon.GetPrice();
    }
}