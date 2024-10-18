using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{
    // Zona de variables globales
    [SerializeField]
    private int _numberOne,
                _numberTwo,
                _numberThree;

    // Start is called before the first frame update
    void Start()
    {
        IsAscendingNumber();
    }

    // Método para determinar el orden ascendiente
    private void IsAscendingNumber()
    {
        // Zona de variables locales
        int numberSmallest,
            numberMiddle,
            numberLargest;

        // Determinar el número de menor a mayor
        if (_numberOne < _numberTwo && _numberOne < _numberThree)
        {
            numberSmallest = _numberOne;

            if (_numberTwo < _numberThree)
            {
                numberMiddle = _numberTwo;
                numberLargest = _numberThree;

            }

            else
            {
                numberMiddle = _numberThree;
                numberLargest = _numberTwo;
            }
        }

        else if (_numberTwo < _numberThree)
        {
            numberSmallest = _numberTwo;

            if (_numberOne < _numberThree)
            {
                numberMiddle = _numberOne;
                numberLargest = _numberThree;
            }

            else
            {
                numberMiddle = _numberThree;
                numberLargest = _numberOne;
            }
        }

        else
        {
            numberSmallest = _numberThree;

            if (_numberTwo < _numberOne)
            {
                numberMiddle = _numberTwo;
                numberLargest = _numberOne;
            }

            else
            {
                numberMiddle = _numberOne;
                numberLargest = _numberTwo;
            }
        }

        // Mostrar en consola orden ascendiente
        Debug.Log("El orden ascendente de los números es: '" + numberSmallest + "' , '" + numberMiddle + "' , '" + numberLargest + "'.");
    }
}
