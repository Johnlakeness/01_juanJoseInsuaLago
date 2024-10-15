using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetMultiplesOfThree();

    }

    // Método "Múltiplos de tres"
    private void GetMultiplesOfThree()
    {
        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                // Monstrar en consola
                Debug.Log(i + " es múltiplo de 3");
            }
        
        }
    }
}
