using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
    // The Monster that should be spawned
    public GameObject monsterPrefab;
    
    // Spawn Delay in seconds
    public float interval = 3;
    
    // Use this for initialization
    void Start() {
        InvokeRepeating("SpawnNext", interval, interval);
    }
    
    void SpawnNext() {
        Instantiate(monsterPrefab, transform.position, Quaternion.identity);
    }
}
