using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumeroMayor : MonoBehaviour
{

    public int Numero1;
    public int Numero2;

    // Start is called before the first frame update
    void Start()
    {
        if (Numero1 > Numero2)
        {
            Debug.Log("El mayor de los dos numeros ingresados es " + (Numero1));
        }

        if (Numero2 > Numero1)
        {
            Debug.Log("El mayor de los dos numeros ingresados es " + (Numero2));
        }

        if (Numero2 == Numero1)
        {
            Debug.Log("Ambos números ingresados son iguales");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
