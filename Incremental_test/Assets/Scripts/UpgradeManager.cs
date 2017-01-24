﻿using UnityEngine;
using System.Collections;

public class UpgradeManager : MonoBehaviour {

	public Click click;
	public UnityEngine.UI.Text itemInfo;
	public float cost;
	public int count = 0;
	public int clickPower;
	public string itemName;
	private float baseCost;



	// Use this for initialization
	void Start () {
		baseCost = cost;
	}
	
	// Update is called once per frame
	void Update () {
		itemInfo.text = itemName + "\nCost: " + cost + "\nPower: +" + clickPower;
	}

	public void PurchasedUprade () {
		if (click.gold >= cost) {
			click.gold -= cost;
			count += 1;
			click.goldperclick += clickPower;
			cost = Mathf.Round (baseCost * Mathf.Pow (1.15f, count));
		}
	}
}
