using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {

    float maxSpeed = 10f;
    Rigidbody2D bullet;
    float lifetime = 10f;

	// Use this for initialization
	void Start () {
        bullet = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifetime);
	}
	
	// Update is called once per frame
	void Update () {
        bullet.velocity = transform.up * maxSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "wall" || collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
