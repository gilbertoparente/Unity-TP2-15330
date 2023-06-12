using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBounddary : MonoBehaviour
{

    public static float leftSide = -3.5f;
    public static float rigthSide = 3.5f;
    public float internalLeft;
    public float internalRigth;

    // Update is called once per frame
    void Update()
    {
        internalLeft = leftSide;
        internalRigth= rigthSide;

    }
}
