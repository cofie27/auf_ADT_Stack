//------------------------------------------------------------------------------------------------------------------------------------
//Dateiname	    : auf_ADT_Stack
//Projekt	    : auf_ADT_Stack
//Beschreibung  :
//Autoren	    : Paul A.
//Erstellung	: 02.06.2021
//letzte Änd.	: 05.06.2021
//Fehler	    : in der Aufgabenstellung (Struktogramm)
//Dokument	    : auf_Stapel1
//------------------------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auf_ADT_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test
            UPN("7 3 + 4 54 6 / + *");
            Console.ReadKey();
        }

        public static void UPN(string term)
        {
            //Stack wird erzeugt
            Stack st1 = new Stack();

            //zerlegt immer nach einem Leerzeichen
            string[] element = term.Split(' ');

            //ergebnis wird intialisiert
            int ergebnis = 0;

            for (int i = 0; i < element.Length; i++)
            {

                if (element[i] == "+" || element[i] == "-" || element[i] == "*" || element[i] == "/")
                {
                    //Fehler im Struktogramm; sonst wird 40 ausgegeben wenn op1 und op2 vertauscht werden
                    int op_2 = st1.Pop();
                    int op_1 = st1.Pop();
                    
                    //Es wird über die unterschiedlichen Operatoren (+,-,/,*) entschieden
                    switch (element[i])
                    {
                        //Falls...
                        case "+":
                            ergebnis = op_1 + op_2;
                            break;

                        case "-":
                            ergebnis = op_1 - op_2;
                            break;

                        case "*":
                            ergebnis = op_1 * op_2;
                            break;

                        case "/":
                            ergebnis = op_1 / op_2;
                            break;

                            //kein Default-Fall möglich wegen der if-Abfrage
                    }
                    
                    //ergebnis wird auf den Stack gelegt
                    st1.Push(ergebnis);
                }
                else
                {
                    //Element wird in nummerischen Datentyp konvertiert
                    int wert = Convert.ToInt32(element[i]);

                    //der "wert" wird auf den Stack gelegt
                    st1.Push(wert);
                }
            }
            //gibt das oberste Element zurück und entfernt es
            ergebnis = st1.Pop();

            if (st1.isEmpty() == true)
            {
                //Ergebnis wird ausgegeben
                Console.WriteLine(ergebnis);
            }
            else
            {
                //Fehler wird ausgegeben
                Console.WriteLine("Fehler");
            }
        }
    }
}
