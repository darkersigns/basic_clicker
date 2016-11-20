using UnityEngine;
using System.Collections;

public class ItemManager : MonoBehaviour {

	public UnityEngine.UI.Text iteminfo;
	public Click click;
	public float cost;
	public int tickvalue;
	public int count;
	public string itemname;
	private float basecost;


	// Use this for initialization
	void Start () {
		basecost = cost;
	}
	
	// Update is called once per frame
	void Update () {
		iteminfo.text = itemname + "\nCost: " + cost + "\nGold: " + tickvalue + "/s";
	}

	public void purchaseditem () {
		if (click.currentgold >= cost) {
			click.currentgold -= cost;
			count =+ 1;
			cost = Mathf.Round (basecost * Mathf.Pow(1.15f, cost));

		}

	}



}
