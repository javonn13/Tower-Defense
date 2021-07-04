using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {

    // Use this for initialization
    void Start () {
        // Navigate to Castle
        GameObject castle = GameObject.Find("Castle");
        if (castle)
            GetComponent<NavMeshAgent>().destination = castle.transform.position;
    }
    
    void OnTriggerEnter(Collider co) {
        // If castle then deal Damage, destroy self
        if (co.name == "Castle") {
            co.GetComponentInChildren<Health>().decrease();
            Destroy(gameObject);
        }
    }
}
