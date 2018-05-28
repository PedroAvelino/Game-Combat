using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {

    //Esse códido vai para a câmera

    public Tank tank;
    public Tank tank2;


    private void Update()
    {
        if(tank.life == 0)
        {
            SceneManager.LoadScene(3);
        }

        if (tank2.life == 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
