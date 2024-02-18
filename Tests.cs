namespace BrumJan24
{
    public class Tests
    {
        //Properties
        public int valuation { get; set; } = 10;
        public int valuation2 { get; set; } = 1;

        [SetUp]
        public void Setup()
        {
            //executable codes
            valuation2 += valuation;
            Console.WriteLine(valuation2);
        }

        [Test]
        public void Test1()
        {
            
        }
    }
}