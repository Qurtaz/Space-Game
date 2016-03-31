using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ToggelPanelButton : MonoBehaviour {

    private Planets planetScript;
    public GameObject player;
    private Player playerScript;
    public void TogglePanel(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }
    public void Choose()
    {
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
