using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetarMoedas : MonoBehaviour
{
    public AudioSource coinFX;

    void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        ContarMoedas.Contador += 1;
        this.gameObject.SetActive(false);
    }
}
