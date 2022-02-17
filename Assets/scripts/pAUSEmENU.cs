using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pAUSEmENU : MonoBehaviour
{
    void FixedUpdate()
    {
        if (PauseScreenBehaviour.paused)
        {
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseScreenBehaviour.paused)
        {
            return;
        }
    }
}
