using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestConsole : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // PRiMITIVE TYPES 
        // UN SOLO CARACTER 
        char letter = 'a';

        // CADENA DE CARACTERES (NO ES UN TIPO PRIMITIVO)
        string name = "Adry";

        //NUMERO ENTERO
        int age = 18;

        // NUMERO ENTERO MUY GRANDE 
        long measure = 1223456789231454;

        // NUMERO ENTERO POSITIVO
        uint money = 1000;

        // Numero DECIMAL 
        float weight = 72.2f;

        // Byte 
        byte myByte = 255;

        // NUMERO DECIMAL DOBLE PRECISION 
        double d = 612.4d;

        // NUMERO DECIMAL
        decimal DEC = 12344.765M;

        // BOLEANO 
        bool isHuman = true; //true  false

        // NUMERO ENTERO PEQUEÑO
        short s = 1;



        Debug.Log(name);



    }
}

    
