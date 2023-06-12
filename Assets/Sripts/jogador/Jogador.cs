using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float velocidade = 5;
    public float velocidadeDireita = 4;
    static public bool move = false;
    public bool saltar = false;
    public bool parabaixo = false;
    public GameObject jogadorObjecto;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * velocidade, Space.World);
        if (move == true)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (this.gameObject.transform.position.x > LevelBounddary.leftSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * velocidadeDireita);
                }
            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (this.gameObject.transform.position.x < LevelBounddary.rigthSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * velocidadeDireita * -1);
                }
            }

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))
            {
                if (saltar == false)
                {
                    saltar = true;
                    jogadorObjecto.GetComponent<Animator>().Play("Jump");
                    StartCoroutine(SaltarSeq());
                }
            }
        }

        if (saltar == true)
        {
            if (parabaixo == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 3, Space.World);
            }
            if (parabaixo == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -3, Space.World);
            }
        }
    }

    IEnumerator SaltarSeq()
    {
        yield return new WaitForSeconds(0.45f);
        parabaixo = true;
        yield return new WaitForSeconds(0.45f);
        saltar = false;
        parabaixo = false;
        jogadorObjecto.GetComponent<Animator>().Play("Standard Run");
    }
}
