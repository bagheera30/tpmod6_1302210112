using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302210112
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Contract.Requires(title != null, "judul tidak boleh berisi kosong");
            Contract.Requires(title.Length <= 100, "judul jumlah karakter harus di bawah 100 karakter");

            this.id = new Random().Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int input)
        {
            Contract.Requires(input > 0 && input <= 10000000, "Count must be between 1 and 10,000,000.");

            try
            {
                checked
                {
                    this.playCount += input;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID: {this.id}\nTitle: {this.title}\nPlay Count: {this.playCount}\n");
        }
    }
}
