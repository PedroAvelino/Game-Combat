using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public Sprite[] LifeSprite = new Sprite[2];

    public Image LifeImage;

    public Tank player;

    public void Awake()
    {
        LifeImage.sprite = LifeSprite[0];
       
    }

    private void Update()
    {
        switch (player.life)
        {
            case 3: LifeImage.sprite = LifeSprite[0];
                break;
            case 2: LifeImage.sprite = LifeSprite[1];
                break;
            case 1: LifeImage.sprite = LifeSprite[2];
                break;
        }
    }
}
