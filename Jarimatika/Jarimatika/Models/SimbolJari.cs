using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarimatika.Models
{
    class SimbolJari
    {
        public string GambarJari { get; set; }
        public string SimbolAngka { get; set; }
    }

    public class SimbolkananManager
    {
        internal static List<SimbolJari> GetKanan()
        {
            var kanans = new List<SimbolJari>();

            kanans.Add(new SimbolJari { GambarJari = "Assets/TanganKanan/Satu.png", SimbolAngka = "Satu" });
            kanans.Add(new SimbolJari { GambarJari = "Assets/TanganKanan/Dua.png", SimbolAngka = "Dua" });
            kanans.Add(new SimbolJari { GambarJari = "Assets/TanganKanan/Tiga.png", SimbolAngka = "Tiga" });
            kanans.Add(new SimbolJari { GambarJari = "Assets/TanganKanan/Empat.png", SimbolAngka = "Empat" });
            kanans.Add(new SimbolJari { GambarJari = "Assets/TanganKanan/Lima.png", SimbolAngka = "Lima" });
            kanans.Add(new SimbolJari { GambarJari = "Assets/TanganKanan/Enam.png", SimbolAngka = "Enam" });
            kanans.Add(new SimbolJari { GambarJari = "Assets/TanganKanan/Tujuh.png", SimbolAngka = "Tujuh" });
            kanans.Add(new SimbolJari { GambarJari = "Assets/TanganKanan/Delapan.png", SimbolAngka = "Delapan" });
            kanans.Add(new SimbolJari { GambarJari = "Assets/TanganKanan/Sembilan.png", SimbolAngka = "Sembilan" });

            return kanans;
        }
    }

    public class SimbolKiriManager
    {
        internal static List<SimbolJari> GetKiri()
        {
            var kiris = new List<SimbolJari>();

            kiris.Add(new SimbolJari { GambarJari = "Assets/TanganKiri/Sepuluh.png", SimbolAngka = "Sepuluh" });
            kiris.Add(new SimbolJari { GambarJari = "Assets/TanganKiri/Duapuluh.png", SimbolAngka = "Duapuluh" });
            kiris.Add(new SimbolJari { GambarJari = "Assets/TanganKiri/Tigapuluh.png", SimbolAngka = "Tigapuluh" });
            kiris.Add(new SimbolJari { GambarJari = "Assets/TanganKiri/Empatpuluh.png", SimbolAngka = "Empatpuluh" });
            kiris.Add(new SimbolJari { GambarJari = "Assets/TanganKiri/Limapuluh.png", SimbolAngka = "Limapuluh" });
            kiris.Add(new SimbolJari { GambarJari = "Assets/TanganKiri/Enampuluh.png", SimbolAngka = "Enampuluh" });
            kiris.Add(new SimbolJari { GambarJari = "Assets/TanganKiri/tujuhpuluh.png", SimbolAngka = "Tujuhpuluh" });
            kiris.Add(new SimbolJari { GambarJari = "Assets/TanganKiri/Delapanpuluh.png", SimbolAngka = "Delapanpuluh" });
            kiris.Add(new SimbolJari { GambarJari = "Assets/TanganKiri/Sembilanpuluh.png", SimbolAngka = "Sembilanpuluh" });

            return kiris;
        }
    }
}
