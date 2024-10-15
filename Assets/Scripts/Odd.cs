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

    private void GetOddNumbers0To100While()
    {
        // Variable de incremento
        int i = 0;

        while (i <= 100)
        {
            if (i % 2 != 0)
            {
                // Monstrar en consola "Odd"
                Debug.Log(i);
            }

            i++; 
        }
    }
}
