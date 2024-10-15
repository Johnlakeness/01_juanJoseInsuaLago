using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{
    // Zona de variables globales
    public int  NumberOne,
                NumberTwo, 
                NumberThree;

    // Start is called before the first frame update
    void Start()
    {
        IsIncreasingOrder();
    }

    // Método Orden creciente
    private void IsIncreasingOrder()
    {
        if(NumberOne <= NumberTwo && NumberTwo <= NumberThree)
        {
            // Mostrar en consola "Creciente"
            Debug.Log ("El orden es creciente.");
         
        }

        else
        {
            // Monstrar en consola "No creciente"
            Debug.Log ("El orden no es creciente.");
        }
    }
}
