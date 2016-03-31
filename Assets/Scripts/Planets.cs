using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Planets : MonoBehaviour {
    public GameObject button;
    public GameObject player;
    public Text text;
    public string owner;
    public int fightStr { get; private set; }
    private int points;
    private Player playerScript;

    private void Awake()
    {
        playerScript = player.GetComponent<Player>();
        owner = "neutral";
        points = 200;
    }
    void Update()
    {
        bunt();
    }
    public int addPoints()
    {
        return points;
    }
    public void addShip(string typShip)
    {
        if(typShip=="Fighter")
        {
            
        }
    }
    public string getOwner()
    {
        return owner;
    }

    void OnTriggerEnter(Collider other)
    {
            if(other.tag == "Player")
            {
                if(owner=="player")
                {
                    text.text = "Manage";
                }
                else
                {
                    text.text = "Atack";
                }
                playerScript.ClosestPlanet = gameObject;
                button.SetActive(true);
            }
    }
    public void changeOwner(string Owner)
    {
        owner = Owner;
        playerScript.addPlanets();
        playerScript.addPoints(points);
    }
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            playerScript.ClosestPlanet = null;
            button.SetActive(false);
        }
    }
   
    public void Atackt()
    {
        //bool win=false;

        //if(win==true)
        //{
        changeOwner("player");
        //}
    }
    public void Manage()
    {

    }
    void bunt()
    {
        if(owner=="player")
        {
            int playerFightStrength = playerScript.getFigrtStrenght();
            int pFS = playerFightStrength - fightStr;
            Debug.Log("ruznica"+pFS);
            if(pFS<0)
            {
                Debug.Log("bunt");
                owner = "neutral";
                playerScript.minusPlanets();
            }
        }
    }
}
