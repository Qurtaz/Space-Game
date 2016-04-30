using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class MainControler : MonoBehaviour {
    public List<GameObject> Planets;
    private Planets planet;
    private Player player;
    private PlayerControler controler;
    private SendDatabeforeScenes data;
    public GameObject playerObject;
    public GameObject canvas;
    public Text text;
    public GameObject savePoints;
    public GameObject saveData;
	// Use this for initialization
	void Start () {
        Debug.Log("start");
        player = playerObject.GetComponent<Player>();
        controler = playerObject.GetComponent<PlayerControler>();
        data = saveData.GetComponent<SendDatabeforeScenes>();
	}
	
	// Update is called once per frame
	void Update () {
        if(data.fight == true && data.finishFight == true)
        {
            data.LoadPlanetsAndPlayer(Planets, playerObject);
            if(data.winer == true)
            {
                AddPlanets();
            }
        }
        if(lose()== true)
        {
            finish();
            text.text = "You lose";
        }
        if(win() == true)
        {
            finish();
            savePoints.SetActive(true);
            text.text = "You win \n Your points is: "+player.getPoints();
        }
        
	
	}
    bool win()
    {
        int z = 0;
        foreach (GameObject mane in Planets)
        {
            planet = mane.transform.Find("ActionObject").gameObject.GetComponent<Planets>();
            if (planet.owner != "player")
            {
                z++;
            }
        }
        if(z!= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    bool lose()
    {
        if(player.getPoints() == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    void finish()
    {
        player.finish = true;
        controler.enabled = false;
        canvas.SetActive(true);
    }
    public void Atack(string name)
    {
        data.nameEnemy = name;
        data.savePlanetsAndPlayer(Planets, playerObject);
        Application.LoadLevel(2);
    }
    void AddPlanets()
    {
        Planets planet;
        foreach(GameObject planets in Planets)
        {
            planet = planets.GetComponent<Planets>();
            if(planet.name == data.nameEnemy)
            {
                planet.Winer();
            }
        }
    }
}
