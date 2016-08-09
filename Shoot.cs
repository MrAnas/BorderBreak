using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {


    public float coolDown;
    private float cooldownCounter;
    public GameObject projectile;
    public float rotationSpeed = 35;
    // Use this for initialization
    void Start () {
        cooldownCounter = coolDown;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed, Space.World);
        if (cooldownCounter > 0)
        {
            cooldownCounter -= Time.deltaTime;
        }
        else
        {
            cooldownCounter = coolDown;
        }
	}


    void OnTriggerEnter(Collider collision)
    {
        //if(collision)
        if (collision.tag.Equals("Enemy"))
        {
            if (cooldownCounter > 0)
            {
                GameObject g = (GameObject) Instantiate(projectile, transform.position, Quaternion.identity);
                g.GetComponent<Projectile>().target = collision.transform;
            }
            else
            {
            }

        }
    }

    void OnTriggerStay(Collider collision)
    {
        if (collision.tag.Equals("Enemy") && Time.time > cooldownCounter)
        {
            GameObject g = (GameObject)Instantiate(projectile, transform.position, Quaternion.identity);
            g.GetComponent<Projectile>().target = collision.transform;
            cooldownCounter = Time.time + coolDown;        
        }
    }

}
