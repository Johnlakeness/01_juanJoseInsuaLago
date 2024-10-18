using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Even : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetEvenNumbers();
    }

    // Método para imprimir números pares del 0 al 100
    private void GetEvenNumbers()
    {
        int i = 0;

        // Bucle "while" hasta 100
        while (i <= 100)
        {
            if (i % 2 == 0)
            {
                // Mostrar en consola número par
                Debug.Log(i);
            }

            // Incrementar valor "i"
            i++;
        }
    }
}
