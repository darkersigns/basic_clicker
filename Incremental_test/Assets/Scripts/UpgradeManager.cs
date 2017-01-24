using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour {

	public Click click;
	public UnityEngine.UI.Text itemInfo;
	public float cost;
	public int count = 0;
	public int clickPower;
	public string itemName;
	private float baseCost;
    public Color unaffordable;
    public Color affordable;
    private Slider _slider;



	// Use this for initialization
	void Start () {
		baseCost = cost;
        _slider = GetComponentInChildren<Slider>();
	}
	
	// Update is called once per frame
	void Update () {
		itemInfo.text = itemName + "\nCost: " + cost + "\nPower: +" + clickPower;

        _slider.value = click.gold / cost * 100;
            if (_slider.value >= 100)
            {
                GetComponent<Image>().color = affordable;
            }
            else
            {
                GetComponent<Image>().color = unaffordable;
            }
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
