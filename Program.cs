namespace HackerRank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new(){ 1,2,3,4,5 };
            Mini_MaxSum.miniMaxSum(numbers);
            List<int> numbers2 = new() { 5,5,5,5,5 };
            Mini_MaxSum.miniMaxSum(numbers2);
        }
    }
}