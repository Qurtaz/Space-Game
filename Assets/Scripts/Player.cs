using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {
    private float points;
    private int money;
    private int fightStr;
    private int planets;
    private float timeRepaet;
    public bool finish = false;
    public GameObject ClosestPlanet;
    private ListOfShips list;

    public ListOfShips returnListOfShip()
    {
        list = gameObject.GetComponent<ListOfShips>();
        return list;
    }
    public float getPoints()
    {
    return points;
    }
    public int getMoney()
    {
    return money;
    }
    public void loadPoints(float points1)
    {
       points=points1;
    }
    public void loadMoney(int money1)
    {
        money = money1;
    }
    public int getFigrtStrenght()
    {
        return fightStr;
    }
    public void addPoints(int value)
    {
        points += value;
    }
    public void addPlanets()
    {
        planets++;
    }
    public void minusPlanets()
    {
        planets--;
    }
    public void setMoney(int value)
    {
        money -= value;
    }
	void Start () {
        points = 50000;
        money = 500;
        fightStr = 0;
        planets = 0;
        timeRepaet = 0.05f;
        InvokeRepeating("minusPoints",timeRepaet,timeRepaet);
        InvokeRepeating("addMoney", timeRepaet*100, timeRepaet*100);
        list.fighter = 10;
        list.ironclad = 5;
	}
    
    void minusPoints()
    {
        if(finish == false)
        {
            points = points - 0.5f;
        }

    }
    void addMoney()
    {
        if(finish == false)
        {
            money = money + 50 + 20 * planets;
        }
        
    }
	
	// Update is called once per frame
	void Update () {
	}
    public void buyFighter()
    {
        list.addFighter();
    }
    public void buyIronclad()
    {
        list.addIroncald();
    }
    public void buySupport()
    {
        list.addSupport();
    }
    public void upgradeFighter()
    {
        list.addUpfighter();
    }
    public void upgradeIronclad()
    {
        list.addUpironcald();
    }
    public void upgradeSupport()
    {
        list.addUpsupport();
    }
}
