using Task_6;
using Task6;

SimpleLightstring lightstring1 = new SimpleLightstring(30);
ColoredLightstring lightstring2 = new ColoredLightstring(20);
Bulb bulb1 = new ColoredBulb(Color.RED,5);
Bulb bulb2 = new SimpleBulb(20
    );

Console.WriteLine(bulb1.IsOn(new DateTime(10)));