using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPanelGame : MonoBehaviour
{
    [SerializeField] GameObject panelPause;

    void Start()
    {
        panelPause.SetActive(true);
    }

    void Update()
    {

    }

    public void ChangePanel(GameObject panel)
    {
        panelPause.SetActive(false);
    }
}
