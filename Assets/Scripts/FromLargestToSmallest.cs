using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromLargestToSmallest : MonoBehaviour
{
    // Zona de variables globales
    public int  NumberOne,
                NumberTwo,
                NumberThree;

    // Start is called before the first frame update
    void Start()
    {
        IsDescendingNumber();
    }

    private void IsDescendingNumber()
    {
        // Zona de variables locales
        int numberSmallest = 0,
            numberMiddle = 0,
            numberLargest = 0;

        // Vincular número a tamaño
        if (NumberOne < NumberTwo && NumberOne < NumberThree)
        {
            numberSmallest = NumberOne;

            if (NumberTwo < NumberThree)
            {
                numberMiddle = NumberTwo;
                numberLargest = NumberThree;

            }

            else
            {
                numberMiddle = NumberThree;
                numberLargest = NumberTwo;
            }
        }

        else if (NumberTwo < NumberOne && NumberTwo < NumberThree)
        {
            numberSmallest = NumberTwo;

            if (NumberOne < NumberThree)
            {
                numberMiddle = NumberOne;
                numberLargest = NumberThree;
            }

            else
            {
                numberMiddle = NumberThree;
                numberLargest = NumberOne;
            }
        }

        else
        {
            numberSmallest = NumberThree;

            if (NumberTwo < NumberOne)
            {
                numberMiddle = NumberTwo;
                numberLargest = NumberOne;
            }

            else
            {
                numberMiddle = NumberOne;
                numberLargest = NumberTwo;
            }
        }

        // Mostrar en consola orden de mayor a menor
        Debug.Log("El orden descendiente de los números es: '" + numberLargest + "' , '" + numberMiddle + "' , '" + numberSmallest + "'.");
    }
}
