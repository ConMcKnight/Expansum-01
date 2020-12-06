using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
   Animator anim;

   void start ()
   {
		  anim = GetComponent<Animator>();
   }

   void OnTriggerEnter (Collider col) 
   {
		  anim.SetBool("isOpen", true);
   }

   void OnTriggerExit (Collider col)
   {
		  anim.SetBool("isOpen", false);
   }
}
