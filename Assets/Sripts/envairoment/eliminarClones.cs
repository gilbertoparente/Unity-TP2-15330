using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eliminarClones : MonoBehaviour
{

    public string cloneNome;

    void Start()
    {
        cloneNome = transform.name;
        StartCoroutine(eliminarClone());
    }

    IEnumerator eliminarClone()
    {
        yield return new WaitForSeconds(50);
        if(cloneNome == "Section(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
