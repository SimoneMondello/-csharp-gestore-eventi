using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
        public string titolo;
        public double data;
        public int postiTotale;
        public int postiPrenotati;

        public int BigliettiRestanti;
        public int BigliettiDisdetti;

        public Evento(string titolo, double data, int postiTotale, int postiPrenotati)
        {
            this.titolo = titolo;
            this.data = data;
            this.postiTotale = postiTotale;
            this.postiPrenotati = postiPrenotati;
        }

        public string GetTitolo()
        {
            Console.WriteLine(titolo);
            return titolo;
        }
        public double GetData()
        {
            return data = 0;

        }
        public int GetpostiTotale()
        {
            return postiTotale = 200;
        }
        public int GetpostiPrenotati()
        {
            return postiPrenotati;
        }

        public int GetBigliettiDisdetti()
        {
            return BigliettiDisdetti;
        }


        public void PrenotaPosti()


        {
            for (int i = 0; i < postiTotale; i++)
            {
                postiTotale = 200;
                if (postiTotale == i) ;

                Console.WriteLine("Il numero di posti totale è" + postiTotale);


                Console.WriteLine("Inserisci quanti posti vuoi prenotare");
                postiPrenotati = int.Parse(Console.ReadLine());


                Console.WriteLine("Grazie per aver prenotato numero posti :" + postiPrenotati);
                postiTotale = postiTotale - postiPrenotati;
                Console.WriteLine(postiTotale);
                return;

            }
        }



        public void DisdiciPosti()


        {
            for (int i = 0; i < postiTotale; i++)
            {
                BigliettiRestanti = postiTotale;
                Console.WriteLine("I biglietti restanti sono " + BigliettiRestanti);

                var continuaCicloWhile = true;
                while (continuaCicloWhile)
                {


                    Console.WriteLine("Vuoi disdire posti? si/no");
                    var rispostaUtente = Console.ReadLine();

                    if (rispostaUtente == "no")
                    {
                        continuaCicloWhile = false;
                        Console.WriteLine("Grazie per la prenotazione");
                        return;
                    }

                    if (rispostaUtente == "si")

                    {
                        Console.WriteLine("Quanti posti vuoi disdire?");

                        BigliettiDisdetti = int.Parse(Console.ReadLine());
                        postiTotale = BigliettiDisdetti + postiTotale;
                        Console.WriteLine("I biglietti disponibili sono" + postiTotale);
                        return;
                    }
                }
            }
        }

                 
         
        public void Data()
        {
            string data = "";
            data += "dd/MM/yyyy";

            Console.WriteLine("Inserisci la data dell'evento (" + data + ")");
            data = Console.ReadLine();
        }



        
    }
}

 /*
            public override string ToString()
            {
                string rappresentazioneInStringa = "";

                rappresentazioneInStringa += "---- Evento ---- \n";
                rappresentazioneInStringa += "Titolo: " + this.titolo + "\n";
                rappresentazioneInStringa += "Data: " + this.data + "\n";
                rappresentazioneInStringa += "Posti Totale Teatro: " + this.postiTotale + "\n";
                rappresentazioneInStringa += "Posti Prenotati: " + this.postiPrenotati + "\n";

                return rappresentazioneInStringa;
            }
 */
            
            



        


     

