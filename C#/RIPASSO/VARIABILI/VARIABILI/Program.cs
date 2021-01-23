//andiamo a vedere che cosa sono e come sono le varibili in C#
// il C# mette i nomi delle variabili sottolieti in verde perche dice che non sono utilizzati, quidni per lui sarebbe meglio toglierli

using System;

namespace VARIABILI{

    class Program{

        static void Main(string[] args){

            //variabili possiamo vederle come delle scatole a cui possiamo inserire un valore, le variabili non possono iniziare con i numeri, posso usare il _ come nome delle variabili

            //tipo di varibili:
            string stringa = "variabili di tipo testo";    //si inserisce un testo fra "" 
            int intero = 2;    //int sono delle variabili per i numero di tipo intero, senza virgola
            float virgola = 2.5f;   //variabili per numeri con virgola e hanno una precisione di 7 zeri, e dopo aver scritto il numero dobbiamo mettere una f  2,5f
            double doppio = 40d;    //usate per numeri con virgola, ma hanno 15 cifre di precisione. Possiamo scriverle con la d finale oppure senza     4.5 = 4.5d
            decimal decimali = 39.5m;    //variabili usate soppratutto nella finanza e hanno 28 cifre di precisione e alla fine si deve metter una "m" che sta per "money"
            bool vero = true;   //uniche variabili che sono vere o falso  (true or false)

            //tutte le variabili sono realizzate cosi:  
            //prima va il tipo di variabile poi il nome della varibile = e infine il valore della variabile 
            //  int (tipo variabile) numeroUno (nome variabile) = 5 (valore della variabile)


            Console.WriteLine(stringa);           //dico: console scrivi la linea(stringa);   mette automaticametne il a capo alla fine della riga

            //posso usare le variabili per contenere dei risultati delle operazioni

            float y = 5;
            y += intero;        //posso utilizzare i segni =+ /+ *= eccetera in modo da essere piu' "comodo". Invece dovrei fare:    y = y + intero;

            Console.WriteLine("Numero: " + y);
            Console.Write("\nSono una variabile con la virgola: ");       //mentre il write non mette il a capo in automatico, am se vogliamo metterlo dobbiamo metterlo con il \n
            Console.Write(virgola + "\n");

            //posso gestirmi le virgole tramite la "funzione" e. si usa cosi:     float y = 5e3f --> 5000

            float k = 5e3f;
            Console.WriteLine("Numero usato con la e: " + k);

            k = 5e-3f;       //posso fare la stessa cosa con la - e succede che il numero si sposta a sinistra
            Console.WriteLine("Numero usato con la e: " + k);


            //oppure possiamo decidere di stampare in diversi modi le nostre varibiali:
            Console.WriteLine("La variabile booleana vale: " + vero);       //aggiungiamo un + ogni volta che vogliamo mettere una varabile dentro a un testo
                                                                            //OOPPURE
            Console.WriteLine("La variabilie souble vale: {0}\nMentre la varaibile decimale vale: {1}", doppio, decimali);       //oppure tramite le {} posso devidere la posizione dove inserire una una variabile dentro al mio testo
                                                                                                                                 //il nuero 0 sta per la prima varaibile inserita, mentre il numero 1 per la seconda e cosi via
            Console.WriteLine($"la prima variabile vale: {vero}");      //in sostanza metto il $ in modo da poter inserire direttamente dentro alle {} la variabilec he voglio stampare. Vale solo nelle "" dove noi inseriamo prima il $

        }
    }
}
