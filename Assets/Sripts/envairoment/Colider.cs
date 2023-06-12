using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colider : MonoBehaviour
{
    public GameObject jogadorMove;
    public GameObject charModel;
    public GameObject controleNivel;
    

    void OnTriggerEnter(Collider other)
    {
        this.GetComponent<BoxCollider>().enabled = false;
        jogadorMove.GetComponent<Jogador>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        controleNivel.GetComponent<Distancia>().enabled = false;
        controleNivel.GetComponent<FimJogo>().enabled = true;

    }
}
