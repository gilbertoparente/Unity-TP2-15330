using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Distancia : MonoBehaviour
{
    public GameObject disContador;
    public GameObject disContadorFim;
    public int distancia;
    public bool distanciaPer = false;
    public float dislay = 0.55f;

    void Update()
    {
        if (!distanciaPer)
        {
            distanciaPer = true;
            StartCoroutine(DistanciaPerCoroutine());
        }
    }

    IEnumerator DistanciaPerCoroutine()
    {
        distancia += 1;
        disContador.GetComponent<TextMeshProUGUI>().text = distancia.ToString();
        disContadorFim.GetComponent<TextMeshProUGUI>().text = distancia.ToString();
        yield return new WaitForSeconds(dislay);
        distanciaPer = false;
    }
}

