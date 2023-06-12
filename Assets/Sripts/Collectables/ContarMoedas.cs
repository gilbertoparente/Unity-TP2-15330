using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ContarMoedas : MonoBehaviour
{
    public static int Contador;
    public GameObject contadorMoedas;
    public GameObject contadorMoedasFim;

    void Update()
    {

        contadorMoedas.GetComponent<TextMeshProUGUI>().text = "" + Contador;
        contadorMoedasFim.GetComponent<TextMeshProUGUI>().text = Contador.ToString();
    }
}
