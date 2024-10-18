using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{
    // Variables globales
    [SerializeField]
    private int _numberOne,
                _numberTwo, 
                _numberThree;

    // Start is called before the first frame update
    void Start()
    {
        IsIncreasingOrder();
    }

    // Método para verificar si el orden es creciente
    private void IsIncreasingOrder()
    {
        if(_numberOne <= _numberTwo && _numberTwo <= _numberThree)
        {
            // Mostrar en consola "Creciente"
            Debug.Log("El orden es creciente.");
         
        }

        else
        {
            // Monstrar en consola "No creciente"
            Debug.Log("El orden no es creciente.");
        }
    }
}
