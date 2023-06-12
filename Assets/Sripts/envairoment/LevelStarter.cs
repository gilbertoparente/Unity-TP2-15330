using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject count3;
    public GameObject count2;
    public GameObject count1;
    public GameObject countGO;
    public GameObject Inicio;

    void Start()
    {
        StartCoroutine(ContagemInicio());
    }

    IEnumerator ContagemInicio()
    {
        yield return new WaitForSeconds(1.5f);
        count3.SetActive(true);
        yield return new WaitForSeconds(1);
        count2.SetActive(true);
        yield return new WaitForSeconds(1);
        count1.SetActive(true);
        yield return new WaitForSeconds(1);
        countGO.SetActive(true);
        Jogador.move = true;
    }
}
