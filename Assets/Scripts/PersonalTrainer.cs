using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalTrainer : MonoBehaviour
{
    public string tipoDeEntrenamiento;
    public int horasAReservar;
    float precioCardio = 1000f;
    float precioRecreativo = 2500f;
    float precioFuerza = 1500f;
    float totalPrecio;
    float totalPrecioConDescuento = 0f;
    // Start is called before the first frame update
    void Start()
    {
        if (tipoDeEntrenamiento == "Cardio")
        {
            if (horasAReservar == 6)
            {
                totalPrecioConDescuento = precioCardio * horasAReservar * 0.9f;
                totalPrecio = precioCardio * horasAReservar;

            }
            else if (horasAReservar < 6 && horasAReservar > 0)
            {
                totalPrecio = precioCardio * horasAReservar;
            }
            else
            {
                Debug.Log("Ingrese una cantidad de horas valida");
                return;

            }
        } else if (tipoDeEntrenamiento == "Fuerza")
        {
            if (horasAReservar == 6)
            {
                totalPrecioConDescuento = precioFuerza * horasAReservar * 0.9f;
                totalPrecio = precioFuerza * horasAReservar;

            }
            else if (horasAReservar < 6 && horasAReservar > 0)
            {
                totalPrecio = precioFuerza * horasAReservar;
            }
            else
            {
                Debug.Log("Ingrese una cantidad de horas valida");
                return;

            }
        }
        else if (tipoDeEntrenamiento == "Recreativo")
        {
            if (horasAReservar == 6)
            {
                totalPrecioConDescuento = precioRecreativo * horasAReservar * 0.9f;
                totalPrecio = precioRecreativo * horasAReservar;

            }
            else if (horasAReservar < 6 && horasAReservar > 0)
            {
                totalPrecio = precioRecreativo * horasAReservar;
            }
            else
            {
                Debug.Log("Ingrese una cantidad de horas valida");
                return;

            }
        }
        else
        {
            Debug.Log("Codigo de actividad ingresado no valido");
            return;
        }
        Debug.Log(tipoDeEntrenamiento);
        Debug.Log(horasAReservar);
        Debug.Log(totalPrecio);
        if(totalPrecioConDescuento != 0)
        {
            Debug.Log(totalPrecioConDescuento);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
