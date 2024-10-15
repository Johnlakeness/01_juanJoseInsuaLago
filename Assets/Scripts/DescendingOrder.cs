using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    // Variables globales
    public int  NumberOne,
                NumberTwo,
                NumberThree;

    // Start is called before the first frame update
    void Start()
    {
        IsDescendingOrder();
    }

    // Método "Orden descendiente"
    private void IsDescendingOrder()
    {
        if (NumberOne >= NumberTwo && NumberTwo >= NumberThree)
        {
            // Mostrar en consola "Descendiente"
            Debug.Log("El orden es descendiente.");
        }

        else
        {
            // Mostar en consola "No descendiente"
            Debug.Log("El orden no es descendiente.");
        }
    }
}
