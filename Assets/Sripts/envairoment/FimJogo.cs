using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FimJogo : MonoBehaviour
{
    public GameObject moedas;
    public GameObject distancia;
    public GameObject endScreen;
    public GameObject fim;

    void Start()
    {
        StartCoroutine(EndSequence());
    }

    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(5);
        moedas.SetActive(false);
        distancia.SetActive(false);
        endScreen.SetActive(true);
        yield return new WaitForSeconds(5);
        fim.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }
}
