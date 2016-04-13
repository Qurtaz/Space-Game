using UnityEngine;
using System.Collections;

public class Space : MonoBehaviour {

	void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
