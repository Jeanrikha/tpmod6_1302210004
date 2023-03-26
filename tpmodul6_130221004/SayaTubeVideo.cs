using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace tpmodul6_130221004
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Contract.Requires(title.Length <= 100, "title");
            Contract.Requires(title != null);
            this.title = title;
            Random random = new Random();
            id = random.Next(10000, 99999);
            playCount = 0;
        }
        public void increasePlayCount(int playCount)
        {
            Contract.Requires(playCount < 10000000);
            try
            {
                checked
                {
                    this.playCount = playCount;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Sudah sampai batas pemutaran");
            }
        }
        public void printVideoDetails()
        {
            Console.WriteLine("ID Video\t: " + id);
            Console.WriteLine("Judul Video\t: " + title);
            Console.WriteLine("View Video\t: " + playCount);
        }

    }
}
