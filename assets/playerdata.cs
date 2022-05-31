using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class playerdata
{
    public float[] position;
    public int score;
    public playerdata (PlayerMovementScript p){
        position = new float[3];

        position[0] = p.transform.position.x;
        position[1] = p.transform.position.y;
        position[2] = p.transform.position.z;
        score = p.score;

    }
}
