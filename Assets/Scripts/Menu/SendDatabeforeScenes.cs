using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SendDatabeforeScenes : MonoBehaviour {
    List<Planets> planets;
    Player player;
    Transform playerTransform;
    public string nameEnemy;
    public bool fight = false;
    public bool finishFight = false;
    public bool winer;
    private Player TempralyPlayer;
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
	}
	
    public void savePlanetsAndPlayer(List<GameObject> Planets, GameObject Player)
    {
        foreach(GameObject planet in Planets)
        {
            planets.Add(planet.GetComponent<Planets>());
        }
        player = Player.GetComponent<Player>();
        playerTransform = Player.transform;
    }
    public void LoadPlanetsAndPlayer(List<GameObject> Planets, GameObject Player)
    {
        foreach (GameObject planet in Planets)
        {
            foreach(Planets plan in planets)
            {
                if(planet.GetComponent<Planets>().name == plan.name)
                {
                    planet.GetComponent<Planets>().owner = plan.owner;
                }
            }
        }
        planets.Clear();
        TempralyPlayer = Player.GetComponent<Player>();
        TempralyPlayer.loadMoney(player.getMoney());
        TempralyPlayer.loadPoints(player.getPoints());
        Player.transform.position = playerTransform.position ;
        Player.transform.rotation = playerTransform.rotation;
        fight = false;
        finishFight = false;
    }

	// Update is called once per frame
	void Update () {
	
	}


}
