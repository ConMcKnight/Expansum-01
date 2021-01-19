using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

	private int KeyCardcount;
	public Text countText;
	
	void Start()
	{
		KeyCardcount = 0;
		SetCountText ();
	}

	void OnTriggerEnter(Collider other)
		{
			if (other.gameObject.CompareTag ("KeyCard"))
				{ 
					other.gameObject.SetActive (false);
					KeyCardcount = KeyCardcount + 1;
					SetCountText ();
				}
		}
		void SetCountText()
		{
			countText.text = "Key Cards: " + KeyCardcount.ToString() + "/9";
		}
		
		 
}
