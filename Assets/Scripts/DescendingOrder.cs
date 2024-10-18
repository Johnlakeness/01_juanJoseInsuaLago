using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    // Variables globales
    [SerializeField]
    private int _numberOne,
                _numberTwo,
                _numberThree;

    // Start is called before the first frame update
    void Start()
    {
        IsDescendingOrder();
    }

    // Método para verificar si el orden de los números es descreciente
    private void IsDescendingOrder()
    {
        if (_numberOne >= _numberTwo && _numberTwo >= _numberThree)
        {
            Debug.Log("El orden es descendiente.");
        }

        else
        {
            Debug.Log("El orden no es descendiente.");
        }
    }
}
