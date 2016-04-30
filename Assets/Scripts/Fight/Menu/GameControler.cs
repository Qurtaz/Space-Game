using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameControler : MonoBehaviour {
    List<GameObject> PlayerShip;
    List<GameObject> EnemyShip;
    public Text FinishComunicate;
    public GameObject canvas;
    private bool winer;
    private bool lose;
    private Color red = Color.red;
    private Color green = Color.green;
    public GameShip ShipsPrefab;
    public GameShip EnemySpawn;
    public GameShip PlayerSpawn;
	// Use this for initialization
	void Start () {
        PlayerShip = new List<GameObject>();
        EnemyShip = new List<GameObject>();
        winer = false;
        lose = false;
	}
	void addShip(int playerFighter, int playerIronclad, int playerSupport, int enemyFighter, int enemyIronclad, int enemySupport)
    {
       list(PlayerShip,playerFighter,ShipsPrefab.Fighter,PlayerSpawn.Fighter);
       list(PlayerShip,playerIronclad,ShipsPrefab.Ironclad,PlayerSpawn.Ironclad);
       list(PlayerShip,playerSupport,ShipsPrefab.Support,PlayerSpawn.Support);
       list(EnemyShip, enemyFighter, ShipsPrefab.Fighter, EnemySpawn.Fighter);
       list(EnemyShip, enemyIronclad, ShipsPrefab.Ironclad, EnemySpawn.Ironclad);
       list(EnemyShip, enemySupport, ShipsPrefab.Support, EnemySpawn.Support);
    }
    void list(List<GameObject> ship, int howMany, GameObject Instacion, GameObject Spawn)
    {
        for(int z=0; z<howMany;z++)
        {
            GameObject o =Instantiate(Instacion,Spawn.transform.position,Spawn.transform.rotation) as GameObject;
            ship.Add(o);
        }
    }
	// Update is called once per frame
	void Update () {
        if(ShipCheck(PlayerShip)==0)
        {
            lose = true;
        }
        else
        {
            if(ShipCheck(EnemyShip)==0)
                {
                    winer = true;
                }
        }
        if(winer == true || lose == true)
        {
            canvas.SetActive(true);
            if(winer== true)
            {
                FinishComunicate.color = green;
                FinishComunicate.text = "Winer\n This Planet is your";
            }
            if (winer == true)
            {
                FinishComunicate.color = red;
                FinishComunicate.text = "Lose \n Buy new ship and try again";
            }
        }
	
	}
    private int ShipCheck(List<GameObject> checkShip)
    {
        int ships = 0;
        foreach (GameObject ship in checkShip)
        {
            if (ship != null)
            {
                ships++;
            }
        }
        return ships;
    }
    
}
