using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {

	public UnityEngine.UI.Text GPC;
	public UnityEngine.UI.Text golddisplay;
	public float currentgold = 0.00f;
	public int goldperclick = 1;



	// Update is called once per frame
	void Update () {
		golddisplay.text = "Gold: " + currentgold;
		GPC.text = goldperclick + " gold/click";
	}



	public void clicked () {
		currentgold += goldperclick;
	}
}
