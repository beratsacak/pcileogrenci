using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcileogrenci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BilgisayarSinifi bilgisayar = new BilgisayarSinifi();
            bilgisayar.anakart = "lenovo";
            bilgisayar.islemci = "AMD Ryzen 7 5700G";
            bilgisayar.ram = 64;
            bilgisayar.ssd = 1024;
            bilgisayar.kasa = "lenovo";
            bilgisayar.ekran = "Philips";
            bilgisayar.klavye = "lenovo";
            bilgisayar.mause = "lenovo";
            OgrenciSinifi ogrenciSinifi = new OgrenciSinifi();
            ogrenciSinifi.numara = 584;
            ogrenciSinifi.ad = "Berat";
            ogrenciSinifi.soyadı = "Saçak";
            ogrenciSinifi.tcno = 11111111111;
            ogrenciSinifi.sınıfı = "10/B";
            ogrenciSinifi.diplamapuan = 83.5;
        }
        public class BilgisayarSinifi
        {
            public string anakart;
            public string islemci;
            public byte ram;
            public int ssd;
            public string kasa;
            public string ekran;
            public string klavye;
            public string mause;
        }
        public class OgrenciSinifi
        {
            public int numara;
            public string ad;
            public string soyadı;
            public ulong tcno;
            public string sınıfı;
            public double diplamapuan;


        }
    }
}
