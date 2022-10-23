// See https://aka.ms/new-console-template for more information


using Task5;

use Task5;

Polynomial firstPol = new Polynomial(3);
Polynomial secondPol = new Polynomial(4,2);
Polynomial thirdPol = new Polynomial(5,5);
Polynomial forthPol = new Polynomial(12,7);

Polynomial result = -firstPol + secondPol + thirdPol - forthPol;
Console.WriteLine(result.toString());
