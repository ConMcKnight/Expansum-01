using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class DropDownTrigger : MonoBehaviour
{
   public GameObject DropDownMove;

   void OnTriggerEnter(Collider other)
   {
       if (other.tag == "Player")
       {
           DropDownMove.GetComponent<Animator>().Play("DropDown");
           this.gameObject.GetComponent<BoxCollider>().enabled = false;
       }
   }
}


