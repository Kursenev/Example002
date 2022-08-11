int a = 10;
int b = 7;
int c = 15;
int max = a;

if(max > b)
{
   if(max > c)
   {
    Console.Write("Max = ");
    Console.WriteLine(max);
   }
   else{
    max = c;
   }
    Console.Write("Max = ");
    Console.WriteLine(max);
}
else{
    max = b;
    Console.Write("Min = ");
    Console.WriteLine(max);
}

