using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetMultiplesOfThreeTwo();
    }

    // M�todo "M�ltiplos de dos y tres"
    private void GetMultiplesOfThreeTwo()
    {
        for (int i = 0;  i <= 100; i++)
        {
            // M�ltiplos comunes de dos y tres 
            if (i % 3 == 0 && i % 2 == 0)
            {
                Debug.Log(i + " es m�ltiplo de 2 y 3");
            }

            // M�ltiplos de tres (sin comunes con dos)
            else if (i % 3 == 0 && i % 2 != 0)
            {
                Debug.Log(i + " es m�ltiplo de 3");
            }

            // M�ltiplos de dos (sin comunes con tres)
            else if (i % 3 != 0 && i % 2 ==0)
            {
                Debug.Log(i + " es m�ltiplo de 2");            
            }
        }
    }
}
