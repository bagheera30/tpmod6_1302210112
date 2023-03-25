using tpmodul6_1302210112;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - muhammad rizki alfian");
        video.IncreasePlayCount(20);
        video.printVideoDetail();
    }
}