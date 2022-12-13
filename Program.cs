namespace HackerRank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>();
            List<int> ar1 = new List<int>();
            ar1.Add(11);
            ar1.Add(2);
            ar1.Add(4);
            List<int> ar2 = new List<int>();
            ar2.Add(4);
            ar2.Add(5);
            ar2.Add(6);

            List<int> ar3 = new List<int>();
            ar3.Add(10);
            ar3.Add(8);
            ar3.Add(-12);
            
            arr.Add(ar1);
            arr.Add(ar2);
            arr.Add(ar3);


            DiagonalDifference.diagonalDifference(arr);
        }
    }
}