namespace Num3
{
    public static class ArrayExtensions
    {
        public static void SortAscending(this int[] array)
        {
            Array.Sort(array);

            foreach(var item in array)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
        }
        public static void Mass()
        {
            int[] kakaa = { 3, 2, 6, 5, 4, 8 };
            SortAscending(kakaa);
            

        }
        static void Main(this string[] args)
        {
            Mass();
            int[] Mas = { 3, 2, 23, 50, 1, };
            SortAscending(Mas);
        }
    }

}