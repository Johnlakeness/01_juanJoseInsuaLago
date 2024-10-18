using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromLargestToSmallest : MonoBehaviour
{
    // Zona de variables globales
    [SerializeField]
    private int _numberOne,
                _numberTwo,
                _numberThree;

    // Start is called before the first frame update
    void Start()
    {
        IsDescendingNumber();
    }

    // Método para determinar el orden descendiente
    private void IsDescendingNumber()
    {
        // Zona de variables locales
        int numberSmallest,
            numberMiddle,
            numberLargest;

        // Determinar el número de mayor a menor
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

        else if (_numberTwo < _numberOne && _numberTwo < _numberThree)
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

        // Mostrar en consola orden descendente
        Debug.Log("El orden descendiente de los números es: '" + numberLargest + "' , '" + numberMiddle + "' , '" + numberSmallest + "'.");
    }
}
