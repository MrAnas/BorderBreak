using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {


    public float movementSpeed;
    public Transform goal;
    NavMeshAgent nav;
    // Use this for initialization
    void Start () {
        nav = GetComponent<NavMeshAgent>();
        nav.destination = goal.position;
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
