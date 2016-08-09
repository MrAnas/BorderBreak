using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

    public bool isTower;
    private Health hscr;
    private Money mscr;
    private EnemyStat escr;
	// Use this for initialization
	void Start () {
        hscr = gameObject.GetComponent<Health>();
        mscr = GameObject.Find("GameManager").GetComponent<Money>();
        if (!isTower)
        {
            escr = gameObject.GetComponent<EnemyStat>();
        }
    }
	
	// Update is called once per frame
	void Update () {
	
        if(hscr.health <= 0)
        {
            if (isTower)
            {
                Destroy(gameObject);
            }else
            {
                //Give resources to the player later with the game manager.
                mscr.money += escr.worth;
                Destroy(gameObject);
            }
        }
	}
}
