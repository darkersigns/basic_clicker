using UnityEngine;
using System.Collections;

public class Goldpersec : MonoBehaviour {

	public UnityEngine.UI.Text gpsdisplay;
	public Click click;
	public ItemManager[] items;

	public int getgoldpersec () {
		int tick = 0;
		foreach (ItemManager item in items) {
			tick += item.count * item.tickvalue;
		}
			return tick;
	}

	public void autogoldpersec () {
		click.currentgold += getgoldpersec();
	}

	IEnumerator autotick () {
		while (true) {
			autogoldpersec();
			yield return new WaitForSeconds(1);
		}

	}
		
	// Use this for initialization
	void Start () {
		StartCoroutine(autotick());
	}
	
	// Update is called once per frame
	void Update () {
		gpsdisplay.text = getgoldpersec() + " gold/sec";
	}
}
