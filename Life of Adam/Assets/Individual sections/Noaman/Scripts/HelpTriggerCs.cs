﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpTriggerCs : MonoBehaviour
{
	[SerializeField]
	private GameObject thingToEnable;

	// Use this for initialization
	void Start ()
	{
		thingToEnable.SetActive(false);
	}

	void OnTriggerEnter(Collider other)
	{
		thingToEnable.SetActive(true);
		this.gameObject.SetActive(false);
	}


}
