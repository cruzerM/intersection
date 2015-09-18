using UnityEngine;
using System.Collections;

public class GameObjectDestroyer : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
		Debug.Log ("before Destroy");
		Destroy(collider.gameObject);
    }
}
