using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    // Variables globales
    public int numberBase;

    // Start is called before the first frame update
    void Start()
    {
        int result = GetAddition(numberBase);
        Debug.Log ("La suma de los n�meros del 1 al " + numberBase + " es: " + result);
    }

    // M�todo "GetAddition"
    private int GetAddition(int position)
    {
        // Variables locales
        int addiction = 0;

        for (int i = 1; i <= numberBase; i++)
        {
            addiction = addiction + i;
        }
        return addiction;
    }
}
