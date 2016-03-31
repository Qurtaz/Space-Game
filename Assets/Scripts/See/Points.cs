using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Points : MonoBehaviour {
    Text text;
    public GameObject obj;
    Player player;
    void Awake()
    {
        text = GetComponent<Text>();
        player = obj.GetComponent<Player>();
    }
	
	// Update is called once per frame
	void Update () {
        text.text = "Score: " + player.getPoints();
	}
}
