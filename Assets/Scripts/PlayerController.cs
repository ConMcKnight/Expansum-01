using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public int KeyCardcount;

	void OnTriggerEnter(Collider other)
		{
			if (other.gameObject.CompareTag ("KeyCard"))
				{ 
					other.gameObject.SetActive (false);
					KeyCardcount = KeyCardcount + 1;
				}
		}
		
		 
}
