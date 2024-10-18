using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetOddNumbers0To100While();
    }

    // M�todo para imprimir n�meros impares del 0 al 100
    private void GetOddNumbers0To100While()
    {
        int i = 0;
        // Bucle "while" hasta 100
        while (i <= 100)
        {
            if (i % 2 != 0)
            {
                // Monstrar en consola n�mero impar
                Debug.Log(i);
            }

            // Incrementar valor "i"
            i++; 
        }
    }
}
