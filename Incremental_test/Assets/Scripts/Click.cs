using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {

	public UnityEngine.UI.Text goldDisplay;
	public UnityEngine.UI.Text gpc;
	public float gold =0.00f;
	public int goldperclick = 1;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		goldDisplay.text = "Gold: " + gold.ToString("F0");
		gpc.text = "GPC: " + goldperclick;
	}

	public void Clicked (){
		gold += goldperclick;

	}
}
