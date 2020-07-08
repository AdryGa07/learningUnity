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


        // Operadores

        // Aritmeticos
        int a = 2;
        int b = 5;
        int c = a + b;  // 7  SUMA

        int dd = a * b;  // 10 MULTIPLICACION
        int e = a / b;  // DIVISION
        int f = a - b;  // -3

        // Lógicos
        // AND
        bool g = true && true;   // true    VERDADERO Y VERDADERO = VERDADERO  1 * 1
        bool g2 = true && false;   // false    VERDADERO Y FALSO = FALSO       1 * 0
        bool g3 = false && true;   // false    FALSO Y VERDADERO = FALSO       0 * 1
        bool g4 = false && false;  // false    FALSO Y FALSO = FALSO           0 * 0

        // OR
        bool h = true || true;   // true    VERDADERO O VERDADERO = VERDADERO   1 + 1 = 1
        bool h2 = true ||  false;   // true    VERDADERO O FALSO = VERDADERO     1 + 0 = 1
        bool h3 = false || true;   // true    FALSO O VERDADERO = VERDADERO     0 + 1 = 1
        bool h4 = false || false;  // false    FALSO O FALSO = FALSO            0 + 0 = 0

        // XOR
        bool i = true ^ true;   // true    VERDADERO O VERDADERO = VERDADERO
        bool i2 = true ^ false;   // false    VERDADERO O FALSO = FALSO 
        bool i3 = false ^ true;   // false    FALSO O VERDADERO = FALSO
        bool i4 = false ^ false;  // true    FALSO O FALSO = VERDADERO



    }
}

    
