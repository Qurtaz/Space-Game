using UnityEngine;
using System.Collections;

public class Support : Ship {
    private int numberRepair;
    void useRepair()
    {
        numberRepair--;
    }
    public void Awake()
    {
        hpMax = 300;
        hp = hpMax;
        typStatku = "Support";
        pancerz = 150;
        atak = 0;
    }

    public override void ulepsz()
    {
        creatUpgrate();
        atak = 20;
    }
    public override void doing(GameObject stat)
    {
        Ship _repair = stat.GetComponent<Ship>();
        if (numberRepair != 0 && stat.tag == "Player")
        {
            _repair.repair();

        }
        else
        {
            shots.dmg = Atack();
        }
    }
    void Update()
    {
        destroy();
    }
}
