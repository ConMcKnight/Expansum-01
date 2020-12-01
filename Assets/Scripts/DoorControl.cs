using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour
{
    Animator anim;
    void Start()
    {
      anim = GetComponent<Animator>();  
    }

    // Update is called once per frame
    void OnTriggerEnter (Collider col)
    {
anim.SetBool ("isOpen", true);
        
    }
void OnTriggerExit (Collider col)
{
anim.SetBool("isOpen", false);
}
}
