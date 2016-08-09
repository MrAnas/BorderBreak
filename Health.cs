using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    public float health;
    TextMesh tm;

    void Start()
    {
        tm = GetComponent<TextMesh>();
    }


    void Update()
    {
        transform.forward = Camera.main.transform.forward;
        if (health < 0)
        {
            Destroy(gameObject);
        }
    }


    public int current()
    {
        return tm.text.Length;
    }

    // Decrease the current Health by removing one '-'
    public void decrease()
    {
        if (current() > 1)
            tm.text = tm.text.Remove(tm.text.Length - 1);
        else
            Destroy(transform.parent.gameObject);
    }
}
