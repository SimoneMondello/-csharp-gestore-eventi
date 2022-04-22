using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class ProgrammaEventi
    {
        public string titolo;
        public List<Evento> Eventi;


        public ProgrammaEventi
            (string titolo, List<Evento> Eventi)
        {
            this.titolo = titolo;
            List<Evento> list = new List<Evento>();
        }


        
    }
    
}

    

