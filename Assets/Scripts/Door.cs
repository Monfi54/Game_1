using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    [SerializeField] float distance;
    RaycastHit hit;
    private void FixedUpdate()
    {
        if (Input.GetButtonDown("E"))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, distance))
            {

                if (hit.transform.tag == "AnimateDoor")
                {
                    Animator anim = hit.transform.GetComponent<Animator>();
                    anim.SetBool("Open", !anim.GetBool("Open"));


                }
            }


        }


    }




}
