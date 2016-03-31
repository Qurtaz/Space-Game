using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {
    private float points;
    private int money;
    private int fightStr;
    private int planets;
    private float timeRepaet;
    public GameObject ClosestPlanet;
    public float getPoints()
    {
    return points;
    }
    public int getMoney()
    {
    return money;
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
        money = value;
    }
	void Start () {
        points = 50000;
        money = 500;
        fightStr = 0;
        planets = 0;
        timeRepaet = 0.05f;
        InvokeRepeating("minusPoints",timeRepaet,timeRepaet);
        InvokeRepeating("addMoney", timeRepaet*100, timeRepaet*100);
	}
    
    void minusPoints()
    {
        points = points - 0.5f;
    }
    void addMoney()
    {
        money = money + 50 + 20 * planets;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
