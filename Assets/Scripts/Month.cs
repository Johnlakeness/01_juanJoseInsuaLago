using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Month : MonoBehaviour
{
    // Zona de variables globales
    [SerializeField]
    private int _monthNumber;

    // Start is called before the first frame update
    void Start()
    {
        IsMonthName();
    }

    // Método para mostrar por consola el mes correspondiente al número
    private void IsMonthName()
    {
        switch (_monthNumber)
        {
            case 1:
                Debug.Log("'" + _monthNumber + "' corresponde a Enero");
                break;

            case 2:
                Debug.Log("'" + _monthNumber + "' corresponde a Febero");
                break;

            case 3:
                Debug.Log("'" + _monthNumber + "' corresponde a Marzo");
                break;

            case 4:
                Debug.Log("'" + _monthNumber + "' corresponde a Abril");
                break;

            case 5:
                Debug.Log("'" + _monthNumber + "' corresponde a Mayo");
                break;

            case 6:
                Debug.Log("'" + _monthNumber + "' corresponde a Junio");
                break;

            case 7:
                Debug.Log("'" + _monthNumber + "' corresponde a Julio");
                break;

            case 8:
                Debug.Log("'" + _monthNumber + "' corresponde a Agosto");
                break;

            case 9:
                Debug.Log("'" + _monthNumber + "' corresponde a Septiembre");
                break;

            case 10:
                Debug.Log("'" + _monthNumber + "' corresponde a Octubre");
                break;

            case 11:
                Debug.Log("'" + _monthNumber + "' corresponde a Noviembre");
                break;

            case 12:
                Debug.Log("'" + _monthNumber + "' corresponde a Diciembre");
                break;

            default:
                Debug.Log("'" + _monthNumber + "' no se corresponde con ningún mes del año.");
                break;
        }
    }
}
