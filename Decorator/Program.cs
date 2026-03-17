

using Decorator;

BaseSword sword = new BaseSword("Меч ученика", 2, 10);
Console.WriteLine($"{sword.GetDescription()}: урон - {sword.GetDamage()}, цена - {sword.GetPrice()}");

SharpeningDecorator swordSharp = new SharpeningDecorator(sword);
SharpeningDecorator swordSharp1 = new SharpeningDecorator(swordSharp);
Console.WriteLine($"{swordSharp1.GetDescription()}: урон - {swordSharp1.GetDamage()}, цена - {swordSharp1.GetPrice()}");

FireRuneDecorator swordFire = new FireRuneDecorator(swordSharp1);
Console.WriteLine($"{swordFire.GetDescription()}: урон - {swordFire.GetDamage()}, цена - {swordFire.GetPrice()}");

BaseAxe axe = new BaseAxe("Топор лесника", 5, 20);
VampirismEnchantDecorator axeVampir = new VampirismEnchantDecorator(axe);
SharpeningDecorator axeSharp = new SharpeningDecorator(axeVampir);
Console.WriteLine($"{axeSharp.GetDescription()}: урон - {axeSharp.GetDamage()}, цена - {axeSharp.GetPrice()}");
