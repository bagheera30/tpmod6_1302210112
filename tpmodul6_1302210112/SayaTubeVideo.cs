using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302210112
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playcount;
        public SayaTubeVideo(string title)
        {
            this.id=new Random().Next(10000, 99999);
            this.title=title;
            this.playcount=0;
        }
        public void IncreasePlayCount(int input)
        {
            this.playcount += input;
        }
        public void printVideoDetail()
        {
            Console.WriteLine("Video ID: {0}", this.id);
            Console.WriteLine("Title: {0}", this.title);
            Console.WriteLine("Play Count: {0}", this.playcount);
        }
    }
}
