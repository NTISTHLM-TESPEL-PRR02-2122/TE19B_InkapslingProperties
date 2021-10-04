using System;


Fighter f1 = new Fighter();

f1.Xp = 9;

Console.WriteLine(f1.Level);


f1.Hp = -900;

Console.WriteLine(f1.Hp);


// f1.TakeDamage(900);

// int h = f1.GetHp() - 900;
// f1.SetHp(h);

// f1.SetHp(f1.GetHp() - 900);



// f1.hp -= 900;

// f1.hp = Math.Max(0, f1.hp);


// if (f1.hp <0)
// {
//   f1.hp = 0;
// }

Console.WriteLine(f1.GetHp());

Console.ReadLine();
