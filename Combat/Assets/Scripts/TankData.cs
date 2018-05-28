using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Tank", menuName = "Tank")]
public class TankData : ScriptableObject {

    public float speed = 10;
    public int Life = 3;
}
