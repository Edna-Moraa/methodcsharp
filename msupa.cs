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
       
        
       public static int CalculateSq(int sq)
        {
           
           int sqqr = sq * sq;

            return sqqr;

        } 
         public static void Main()
        {
            Console.WriteLine("Please enter number");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("please enter ints:");
                int x = int.Parse(Console.ReadLine()); 
                int sqqr = CalculateSq(x);
                Console.WriteLine($"your square = {sqqr}");
                
            }
         
        }
   
        
      
        
    }
}

        