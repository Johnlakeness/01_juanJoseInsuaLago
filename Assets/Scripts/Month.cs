using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Month : MonoBehaviour
{
    // Zona de variables globales
    public int MonthNumber;

    // Start is called before the first frame update
    void Start()
    {
        IsMonthName();
    }

    // Método "Nombre del mes"
    private void IsMonthName()
    {
        switch (MonthNumber)
        {
            case 1:
                Debug.Log("'" + MonthNumber + "' corresponde a Enero");
                break;

            case 2:
                Debug.Log("'" + MonthNumber + "' corresponde a Febero");
                break;

            case 3:
                Debug.Log("'" + MonthNumber + "' corresponde a Marzo");
                break;

            case 4:
                Debug.Log("'" + MonthNumber + "' corresponde a Abril");
                break;

            case 5:
                Debug.Log("'" + MonthNumber + "' corresponde a Mayo");
                break;

            case 6:
                Debug.Log("'" + MonthNumber + "' corresponde a Junio");
                break;

            case 7:
                Debug.Log("'" + MonthNumber + "' corresponde a Julio");
                break;

            case 8:
                Debug.Log("'" + MonthNumber + "' corresponde a Agosto");
                break;

            case 9:
                Debug.Log("'" + MonthNumber + "' corresponde a Septiembre");
                break;

            case 10:
                Debug.Log("'" + MonthNumber + "' corresponde a Octubre");
                break;

            case 11:
                Debug.Log("'" + MonthNumber + "' corresponde a Noviembre");
                break;

            case 12:
                Debug.Log("'" + MonthNumber + "' corresponde a Diciembre");
                break;

            default:
                Debug.Log("'" + MonthNumber + "' no se corresponde con ningún mes del año.");
                break;
        }
    }
}
