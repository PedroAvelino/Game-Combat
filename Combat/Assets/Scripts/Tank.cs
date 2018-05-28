using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour {

    public TankData data;
    Rigidbody2D rgb;
    public int life;

    public GameObject shot;
    public Transform shotlocation;


    public string Horizontal = "Horizontal_P1";
    public string Vertical = "Vertical_P1";
    public string Left = "Left_P1";
    public string Up = "Up_P1";
    public string Right = "Right_P1";
    public string Down = "Down_P1";
    public string Disparo = "Tiro_P1";

    public int NoT = 2;

    void Start () {
        rgb = GetComponentInParent<Rigidbody2D>();
        life = data.Life = 3;
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis(Horizontal);
        float y = Input.GetAxis(Vertical);
        Movimento(h, y);

        if (Input.GetButtonDown(Disparo))
        {
            Tiro();
        }
    }

    void Movimento(float h, float y)
    {
        rgb.velocity = new Vector2(y * data.speed, rgb.velocity.y);
        rgb.velocity = new Vector2(h * data.speed, rgb.velocity.x);


        if (Input.GetButtonDown(Left))
        {
            gameObject.transform.localRotation = Quaternion.Euler(0, 0, 90);
            
        }
        if (Input.GetButtonDown(Right))
        {
            gameObject.transform.localRotation = Quaternion.Euler(0, 0, -90);
  
        }
        if (Input.GetButtonDown(Down))
        {
            gameObject.transform.localRotation = Quaternion.Euler(0, 0, 180);
        }
        if (Input.GetButtonDown(Up))
        {
            gameObject.transform.localRotation = Quaternion.Euler(0, 0, 360);
        }

    }

    void Dano()
    {
        life -= 1;
    }

    void Tiro()
    {
       GameObject shotClone = (GameObject) Instantiate(shot, shotlocation.position, shotlocation.rotation);
        shotClone.transform.localRotation = transform.localRotation;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "shot")
        {
            Dano();
        }
    }

}
