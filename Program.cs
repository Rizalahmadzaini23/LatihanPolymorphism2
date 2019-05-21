using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolymorphism2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.nmp = "18.11.2250";
            mhs.nama = "rizal ahmad z";
            mhs.email = "rizal@gmail.com";

            Console.WriteLine("Pilih Format konversi data :");
            Console.WriteLine("1. Json");
            Console.WriteLine("2. XML");
            Console.WriteLine("3. Csv\n");

            Console.WriteLine("Nomor Format Data [1...3]");
            int nomorFormatData = Convert.ToInt32(Console.ReadLine());

            IConvertObject convert;

            if (nomorFormatData == 1)
                convert = new ConvertToJson();
            else if (nomorFormatData == 2)
                convert = new ConvertToXml();
            else
                convert = new ConvertToCsv();

            convert.Convert(mhs);

            Console.ReadKey();
        }
    }
}
