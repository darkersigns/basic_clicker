using UnityEngine;
using System.Collections;

public class TogglePanelButton : MonoBehaviour {

    public void TogglePanel(GameObject panel) {
        panel.SetActive(!panel.activeSelf);
    }

    // Use this for initialization
    void Start()
    {
        
    }
}
