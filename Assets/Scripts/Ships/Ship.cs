using UnityEngine;
using System.Collections;


    
    public class Ship:MonoBehaviour
    {
        public GameObject Shot;
        protected Schoot shots;
        void Awake()
        {
            shots = Shot.GetComponent<Schoot>();
        }
        public GameObject game;
        public int hp { get; protected set; }
        public int hpMax { get; protected set; }
        public int atak { get; protected set; }
        public int pancerz { get; protected set; }
        public bool ulepszenie { get; protected set; }
        public int koszt { get; protected set; }
        public string typStatku { get; protected set; }
        
        public void creatUpgrate()
        {
            ulepszenie = true;
        }
        public void destroyUpgrate()
        {
            ulepszenie = false;
        }
        public virtual void ulepsz()
        {

        }
        public virtual float getFightStrenght()
        {
            return hp / 50 + atak / 50 + pancerz / 20;
        }
        public virtual void doing(GameObject stat)
        {

        }
        public virtual void setHP(int atak)
        {
            if(pancerz<atak)
            {
                hp -= (atak - pancerz);
            }
        }
        public void repair()
        {
            int repair= hpMax-hp;
            hp = hp + repair;
        }
        public void destroy()
        {
            if(hp <= 0)
            {
                Destroy(game);
            }
        }
        public bool canRepair()
        {
            if(hp<hpMax)
            {
                return true; 
            }
            return false;
        }
        public virtual int Atack()
        {
            return atak;
        }
        
    }
