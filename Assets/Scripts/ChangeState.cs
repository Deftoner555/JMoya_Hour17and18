using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeState : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("ChangeColor");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("ChangeScale");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("LampSpin");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("Hover");
        }
    }
}
