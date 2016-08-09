using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    public float movmentSpeed;
    public float damage;
    public Vector3 initpos;
    public GameObject explosion;
    public Transform target;
    
	// Use this for initialization
	void Start () {
        initpos = transform.position;
        damage = 25;

	}

    // Update is called once per frame
    void FixedUpdate() {
        if (target)
        {
            Debug.Log(target);
            Vector3 dir = target.position - transform.position;
            GetComponent<Rigidbody>().velocity = dir.normalized * movmentSpeed;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Enemy")
        {
            col.GetComponent<Health>().health -= damage;
            // We can create a a particles here.
            Destroy(gameObject);

        }
    }
}
