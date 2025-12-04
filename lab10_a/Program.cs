int i = 0;
while (true)
{
   if (i == 4)
   {
       Console.WriteLine("ERROR: Should not happen");
       break;
   }
   if (i == 3)
   {
       Console.WriteLine("Exit");
       break;
   }
   if (i == 0)
   {
       Console.WriteLine("Increase by 2 on first iter");
       i += 2;
       continue;
   }

   Console.WriteLine("Increase by 1 normally");
   i++;

   // Implicit continue.
   // continue;
}