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
    class Stack
    {
        //elements wird deklariert
        private int[] elements;

        //pointer wird deklariert
        private int pointer;

        public  Stack()
        {
            //elements wird initialisiert
            elements = new int[10];

            //pointer wird initialisiert
            pointer = 0;
        }

        //Fügt ein Element auf den Stack hinzu
        public void Push(int element)
        {
            //das Element des index ("pointer") wird auf das übergebene "element" gesetzt
            elements[pointer]= element;
            pointer++;
        }

        //Entfernt oberstes Element aus dem Stack und gibt es zurück
        public int Pop()
        {
            int oberstesElement;

            //oberstes Element liegt "unter" dem Element mit dem index ("pointer")
            oberstesElement = elements[pointer-1];
            pointer = pointer -1;
            return oberstesElement;
        }

        //Gibt das oberste Element aus dem Stack zurück, ohne es zu entfernen
        public int Top()
        {
            int oberstesElement;
            oberstesElement = elements[pointer - 1];
            return oberstesElement;
        }

        //Gibt 'wahr‘ zurück, falls der Stack leer ist
        public bool isEmpty()
        {
            bool isEmpty;
            if(pointer==0)
            {
                isEmpty = true;
            }
            else
            {
                isEmpty = false;
            }
            return isEmpty;
        }
    }
}
