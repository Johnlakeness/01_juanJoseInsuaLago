using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    // Variables globales
    [SerializeField]
    private int _numberBase;

    // Start is called before the first frame update
    void Start()
    {
        // Sumar números del 1 al _numberBase
        int result = CalculateAddition(_numberBase);

        // Mostrar por consola
        Debug.Log ("La suma de los números del 1 al " + _numberBase + " es: " + result);
    }

    // Método para sumar valores de 1 a "number"
    private int CalculateAddition(int number)
    {
        int addiction = 0;

        // Bucle para acumular suma
        for (int i = 1; i <= number; i++)
        {
            // Sumar valor actual de "i" a "addiction"
            addiction += i;
        }
        // Devolver resultado
        return addiction;
    }
}
