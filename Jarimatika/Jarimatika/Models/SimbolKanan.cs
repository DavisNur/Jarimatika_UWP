using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarimatika.Models
{
    class SimbolKanan
    {
        public string GambarJari { get; set; }
        public string SimbolAngka { get; set; }
    }

    public class SimbolkananManager
    {
        internal static List<SimbolKanan> GekKanan()
        {
            var kanans = new List<SimbolKanan>();

            kanans.Add(new SimbolKanan { GambarJari = "Assets/TanganKanan/Satu.png", SimbolAngka = "Satu" });
            kanans.Add(new SimbolKanan { GambarJari = "Assets/TanganKanan/Dua.png", SimbolAngka = "Dua" });
            kanans.Add(new SimbolKanan { GambarJari = "Assets/TanganKanan/Tiga.png", SimbolAngka = "Tiga" });
            kanans.Add(new SimbolKanan { GambarJari = "Assets/TanganKanan/Empat.png", SimbolAngka = "Empat" });
            kanans.Add(new SimbolKanan { GambarJari = "Assets/TanganKanan/Lima.png", SimbolAngka = "Lima" });
            kanans.Add(new SimbolKanan { GambarJari = "Assets/TanganKanan/Enam.png", SimbolAngka = "Enam" });
            kanans.Add(new SimbolKanan { GambarJari = "Assets/TanganKanan/Tujuh.png", SimbolAngka = "Tujuh" });
            kanans.Add(new SimbolKanan { GambarJari = "Assets/TanganKanan/Delapan.png", SimbolAngka = "Delapan" });
            kanans.Add(new SimbolKanan { GambarJari = "Assets/TanganKanan/Sembilan.png", SimbolAngka = "Sembilan" });

            return kanans;
        }
    }
}
