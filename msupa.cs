namespace leetcode
{
    public static class msupa
    {
        
        public static int wababa = 40; 
        public static int CalculateDate(DateTime DateOfBirth)
        {
            int age = DateTime.Now.Year - DateOfBirth.Year;
            return age;
        }
        public static int[] ArrIntergers(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = i;
                
            }
            return array;

        }
        public static int Sum(int[] arr)
        {
            int total = 0;
           for (int i = 0; i < arr.Length; i++)
           {
            total += arr[i];

           }
           return total;

        }
       
        
       public static int[] CalculateSq(int[] sq)
        {
           for (int i = 0; i < sq.Length; i++)
           {
           
            sq[i] = (int)Math.Pow(sq[i], 2);
           }
            
        return sq;
        }

         public static void PrintArray(int[] array)
         {
           for (int i = 0; i < array.Length; i++)
           {
            Console.WriteLine(array[i]);
           }

         }
       
   
        
      
        
    }
}

        