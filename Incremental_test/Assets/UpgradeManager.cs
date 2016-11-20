using UnityEngine;
using System.Collections;

public class UpgradeManager : MonoBehaviour {

	public Click click;
	public UnityEngine.UI.Text iteminfo;
	public float cost; 
	public int count = 0;
	public int clickpower;
	public string itemname;
	private float basecost;


	// Use this for initialization
	void Start () {
		basecost = cost;
	
	}
	
	// Update is called once per frame
	void Update () {
		iteminfo.text = itemname + "\nCost: " + cost + "\nPower: +" + clickpower;
	}

	public void PurchasedUpgrade () {
		if (click.currentgold >= cost) {
			click.currentgold -= cost;
			count += 1;
			click.goldperclick += clickpower;
			cost = Mathf.Round (basecost * Mathf.Pow (1.15f, count));

		}
	}
}
