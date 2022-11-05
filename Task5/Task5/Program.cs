// See https://aka.ms/new-console-template for more information

using System.Globalization;
using Task5;

int[] arr1 = new[] { 0,1,2,3 };
int[] arr2 = new[] { 0,5,6 , 2};

var polynomial1 = new Polynomial(arr1);
var polynomial2 = new Polynomial(arr2);

var result = polynomial1 + polynomial2;

Console.WriteLine(result);

// [0,1] [0,2]  x*2x = 2xy^2   [0,0,2]  [0,0,1] [0,1]  
