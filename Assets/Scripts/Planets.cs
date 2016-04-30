using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Planets : MonoBehaviour {
    public GameObject button;
    public GameObject player;
    public Text text;
    public string owner;
    public string name;
    public Text PlanetsData;
    public int fightStr { get; private set; }
    private int points;
    private Player playerScript;
    private Color enemyColor = Color.red;
    private Color neutralColor = Color.white;
    private Color playerColor = Color.green;
    private ListOfShips list;
    private MainControler main;

    public ListOfShips returnListOfShip()
    {
        list = gameObject.GetComponent<ListOfShips>();
        return list;
    }
    private void Awake()
    {
        Debug.Log("Planets");
        playerScript = player.GetComponent<Player>();
        owner = "neutral";
        points = 200;
        main = GameObject.Find("GameControler").GetComponent<MainControler>();
    }
    void Update()
    {
        data();
        bunt();
    }
    public int addPoints()
    {
        return points;
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
        Debug.Log("Atack PLanet");
        main.Atack(name);
    }
    public void Winer()
    {
        this.changeOwner("player");
        playerScript.addPlanets();
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
            if(pFS<0)
            {
                Debug.Log("bunt");
                owner = "neutral";
                playerScript.minusPlanets();
            }
        }
    }
    void data()
    {
        if(owner =="player")
        {
            PlanetsData.color = playerColor;
        }
        if(owner == "enemy")
        {
            PlanetsData.color = enemyColor;
        }
        if(owner == "neutral")
        {
            PlanetsData.color = neutralColor;
        }
        PlanetsData.text = name + "\n Fight Strenght" + fightStr;
    }
}
