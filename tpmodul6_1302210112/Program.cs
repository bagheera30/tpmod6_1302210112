using tpmodul6_1302210112;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Tutorial Design By Contract - muhammad rizki alfian");
        SayaTubeVideo video2 = new SayaTubeVideo(null);
        SayaTubeVideo video3 = new SayaTubeVideo("Lorem ipsum dolor sit amet consectetur adipisicing elit. Accusamus fugiat tempore nobis ducimus voluptatem deleniti in temporibus quasi praesentium ipsam, aliquid consequatur ratione nemo sit obcaecati inventore sed exercitationem dolorem quos delectus pariatur consectetur nam. Perspiciatis vitae impedit dignissimos error quisquam nulla a necessitatibus quae quo corrupti iusto esse tempore architecto illum enim eum laborum quasi consequuntur aliquid quaerat sapiente cumque, explicabo officia ad? Explicabo exercitationem quibusdam corrupti quaerat eaque? Tempore minus corrupti, voluptates nihil ipsa consectetur adipisci quaerat, incidunt vel quibusdam architecto autem tenetur dolorem aut omnis modi ullam libero, perferendis alias nisi! Nisi minima eum architecto suscipit repellat.");
        SayaTubeVideo video4 = new SayaTubeVideo("Video Exception Test");

        try
        {
            for (int i = 0; i < 1000000; i++)
            {
                video4.IncreasePlayCount(1000); // memanggil method IncreasePlayCount() dengan jumlah yang melebihi batas maksimal
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex.Message); // menampilkan pesan exception
        }

        // Menampilkan detail video
        video1.IncreasePlayCount(20);
        video1.PrintVideoDetails();
        video2.PrintVideoDetails();
        video3.PrintVideoDetails();
        video4.PrintVideoDetails();

        Console.ReadKey();



    }
}