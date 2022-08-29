namespace EnterNumbers
{
    public class NumberRange
    {
        public void ReadNumber(int start, int end)
        {
            try
            {
                int[] arr = new int[10];
                int j = 1;

                for (int i = 0; i < 10; i++, j++)
                {
                    Console.Write("Enter Integer No " + j + ":- ");
                    arr[i] = Int32.Parse(Console.ReadLine());
                }

                Console.WriteLine("Array Values Are:- ");

                for (int k = 0; k < 10; k++)
                {
                    Console.WriteLine(arr[k]);

                    if (start < arr[k] && arr[k] < end)
                    {
                        Console.WriteLine("These Values Are In The Range!");
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new ArgumentOutOfRangeException(
                    "These Values Are Not Valid Or In The Range Between 1-100!");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                NumberRange range = new NumberRange();
                range.ReadNumber(1, 100);
                Console.ReadKey();
            }
        }
    }
}