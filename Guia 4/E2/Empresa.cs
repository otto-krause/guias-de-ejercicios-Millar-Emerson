using System.Collections.Generic;
using System;
namespace E2
{
    public class Empresa
    {
        List<monster_energy> monstruos=new List<monster_energy>();
        public Empresa()
        {
            monster_energy Wazowski=new Amigables(71,"Mike");
            monstruos.Add(Wazowski);
        }
        public void NochedeSustos()
        {
            foreach(monster_energy x in monstruos)
            {
                x.asustar();
            }
        }
        public void NochedeRisas()
        {
            foreach(monster_energy x in monstruos)
            {
                x.reir();
            }
        }
        public List<monster_energy> Respetables()
        {
            List<monster_energy> respetados=new List<monster_energy>();
            foreach(monster_energy x in monstruos)
            {
                if(x.Respeto()>70)
                {
                    respetados.Add(x);
                }
            }
            return respetados;
        } 
        public int Energia()
        {
            int energia=0;
            foreach(monster_energy x in monstruos)
            {
                energia+=x.Respeto();
            }
            return energia;
        }
    }
}