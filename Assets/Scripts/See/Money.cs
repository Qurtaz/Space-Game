using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Money : MonoBehaviour {
    Text text;
    public GameObject obj;
    Player player;
	void Awake () {
        text = GetComponent<Text>();
        player = obj.GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "Money: " + player.getMoney();
	}
}
