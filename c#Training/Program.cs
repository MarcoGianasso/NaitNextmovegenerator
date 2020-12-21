using System;

namespace c_Training
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Console.Title="Nait's Next Move generator";           
            Console.ForegroundColor=ConsoleColor.Green;

            Console.WriteLine("quale sarà la prossima cazzata del nait?");
             Console.WriteLine("da quanti giorni non lo vedi?");
        Int64 num =Convert.ToInt64(Console.ReadLine());
             Console.WriteLine("sotto che sostanza era l'ultima volta che l'hai visto");
         string sostanza = Console.ReadLine();
             Console.WriteLine("il nome dell'ultima tipa di cui si è invaghito");
        string tipa = Console.ReadLine();
        string tempo;
        string caso01;
        string caso02;
        string caso03;
        string caso04;
        string caso05;
        string caso06;
        string effettoDroga;
        string effettoDroga2;
        string effettoDroga3;


       

       // string [] sostanze= {"eroina","cocaina","alcool","lsd","mdma"};
        string [] tempi={"qualche giorno fa.","la settimana scorsa.","l'anno scorso","due minuti fa.","ieri","in questo istante"};

//fattore x calcolato in giorni pari o dispari (si dice che il nait abbia piu sfiga nei giorni dispari)
        bool factorx;
         if (num % 2 ==0 ){
         factorx=true;
        }else{
         factorx=false;
        };
        string [] caso1 = {"e tutto l'oro dei suoi genitori","e anche il culo"};
        string [] caso2 = {"farsi buttare fuori di casa","ucciderla durante la lite."};
        string [] caso3 = {"i ponti con Nait, dopo che lo ha beccato a farsi di "+sostanza+" in vena ","il pene del Nait con un coltello dopo averlo sorpreso a letto con un altro uomo "};
        string [] caso4 = {"si è spogliato nudo","ha defecato sul bancone"};
        string [] caso5 = {"che si masturbava","che violentava una minorenne"};
        string [] caso6 = {"è sato arrestato","gli è stato fatto un TSO"};


   if (factorx==true){
        caso01 = caso1[0];
        caso02 = caso2[0];
        caso03 = caso3[0];
        caso04 = caso4[0];
        caso05 = caso5[0];
        caso06 = caso6[0];
  
   }else{
        caso01 = caso1[1];
        caso02 = caso2[1];
        caso03 = caso3[1];
        caso04 = caso4[1];
        caso05 = caso5[1];
        caso06 = caso6[1];

   };


//assegnazione variabile tempo 
        if ( num >10 && num < 20){
          tempo=tempi[0];   //"qualche giorno fa.";
        }else if (num >20 && num <360){
         tempo =tempi [1];     //"la settimana scorsa.";
        }else if (num>360){
          tempo =tempi[2];     //"l'anno scorso";
        }else if(num==0){
           tempo = tempi[3];    //"due minuti fa.";
        }else if(num<10 && num>2){
         tempo = tempi[4];    //"ieri"
        }else{
           tempo = tempi[5];    //"in questo istante"
        };

//assegnazione sostanze
 
switch(sostanza){
case "eroina" :
effettoDroga ="cercava della carta stagnola";
effettoDroga2 ="con una siringa attaccata al braccio";
effettoDroga3 =" perchè ha cercato di rubare gesu bambino dal presepe.";
break;
case "cocaina" :
effettoDroga ="era pippato come un cane";
effettoDroga2 ="perchè aveva finito la coca";
effettoDroga3 ="per aver pippato le ceneri di padre pio pensando fosse cocaina.";
break;
case "alcool" :
effettoDroga ="era sbronzo come una merda";
effettoDroga2 ="con una bottiglia di vodka ";
effettoDroga3 ="perchè ha minacciato un carabiniere con un coltello.";
break;
case "lsd" :
effettoDroga ="era in preda ad una crisi mistica";
effettoDroga2 ="mentre invocava la gloria del signore";
effettoDroga3 ="dai militari della squadra mobile, mentre cercava di convincerli in maniera delirante che siamo solo campi di energia che vibrano e che la morte non esiste.";
break;
case "mdma" :
effettoDroga ="voleva manifestare il suo amore verso la barista";
effettoDroga2 ="perchè "+tipa+" non c'era";
effettoDroga3 ="all areoporto, lo hanno portato via mentre implorava a "+tipa+" di non lasciarlo.";
break;
default :
effettoDroga ="ha visto "+tipa+"che si baciava con un tipo";
effettoDroga2 ="perche si sentiva solo";
effettoDroga3 ="per pedofilia. ";
break;

}
 




   NextMoveGen(); 

            Console.ReadKey();


 void NextMoveGen (){
     Random numgen = new Random();
    int index = numgen.Next(0,5);

   



      string [] cazzate = {"ha dovuto vendere l' appartamento "+caso01+" per pagare i debiti di "+sostanza +" "+tempo,
                            "ha litigato con "+tipa+" "+tempo+", finendo per "+caso02,
                            "il padre di "+tipa+" ha tagliato "+caso03+" "+tempo,
                            tempo+".. è andato al kaos e "+caso04+" perchè "+effettoDroga,
                            "lo hanno beccato che "+caso05+" "+effettoDroga2+" "+tempo,
                            tempo+".."+caso06+" "+effettoDroga3
                            };
      Console.WriteLine(cazzate[index]);
     
        };

         
    


        }
    }
}
