using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mixamo_dude : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            anim.SetTrigger("Run");
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            anim.SetTrigger("Jump");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            anim.SetTrigger("Attack");
        }
    }
}
