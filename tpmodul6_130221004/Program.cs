using tpmodul6_130221004;

class main
{
    public static void Main(String[] args)
    {
        SayaTubeVideo V1 = new SayaTubeVideo("Tutorial Design By Contract - Jean Rika Haryadi");
        V1.printVideoDetails();

        Console.WriteLine();

        SayaTubeVideo V2 = new SayaTubeVideo("omozoc");
        V2.printVideoDetails();

        for (int i = 0; i < 10000001; i += 10000000)
        {
            V1.increasePlayCount(1000000);
        }
        Console.WriteLine();
        V1.printVideoDetails();
    }
}