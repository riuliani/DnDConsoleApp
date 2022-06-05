// See https://aka.ms/new-console-template for more information
using DnDCore;

Console.WriteLine("Hello, World!");
var herelian = new Herelian("Herelian", 105);

var damage = Combat.AttackEnemy(herelian);
herelian.AddDamageDone(damage);
Console.WriteLine($"Total damage done by {herelian.Name}: {herelian.DamageDone}");