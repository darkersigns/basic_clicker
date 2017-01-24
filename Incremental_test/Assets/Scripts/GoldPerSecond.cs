using UnityEngine;
using System.Collections;

public class GoldPerSecond : MonoBehaviour {

	public UnityEngine.UI.Text gpsdisplay;
	public Click click;
	public GoldPerSecondUpgrades[] items;

	public float GetGoldPerSec (){
		float tick = 0;
		foreach (GoldPerSecondUpgrades item in items) {
			tick += item.count * item.tickValue;

		}
		return tick;
	}

	public void AutoGoldPerSec (){
		click.gold += GetGoldPerSec () / 10;

	}

	IEnumerator AutoTick (){
		while (true) {
			AutoGoldPerSec();
			yield return new WaitForSeconds(0.10f);
		}
	}

	// Use this for initialization
	void Start () {
		StartCoroutine(AutoTick());
	}
	
	// Update is called once per frame
	void Update () {
		gpsdisplay.text = GetGoldPerSec () + " Gold /s";
	}
}
