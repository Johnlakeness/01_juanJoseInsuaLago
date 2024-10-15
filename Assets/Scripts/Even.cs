using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Even : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetEvenNumbers0To100While();
    }

    private void GetEvenNumbers0To100While()
    {
        // Variable de incremento
        int i = 0;

        while (i <= 100)
        {
            if (i % 2 == 0)
            {
                // Mostrar en consola "Even"
                Debug.Log(i);
            }

            i++;
        }
    }
}
