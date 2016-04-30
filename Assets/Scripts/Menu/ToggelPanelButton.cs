using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ToggelPanelButton : MonoBehaviour {

    private Planets planetScript;
    public GameObject player;
    private Player playerScript;
    private MainControler main;
    public void TogglePanel(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }
    public void Choose()
    {
        main = gameObject.GetComponent<MainControler>();
        playerScript = player.GetComponent<Player>();
            planetScript=playerScript.ClosestPlanet.GetComponent<Planets>();
            if(planetScript.getOwner()=="player")
            {
                planetScript.Manage();
            }
            else
            {
                planetScript.Atackt();
            }
    }
}
