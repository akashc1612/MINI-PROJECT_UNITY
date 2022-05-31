using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 12f;
    public int score;
    void Start (){
        playerdata data = savesystem.LoadPlayer();
        Vector3 position1;
        position1.x = data.position[0];
        position1.y = data.position[1];
        position1.z = data.position[2];
        transform.position = position1;
        score = 0;
    }
    void Update ()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        savesystem.SavePlayer(this);
    }
    void OnEnable (){
        playerdata data = savesystem.LoadPlayer();
        Vector3 position1;
        position1.x = data.position[0];
        position1.y = data.position[1];
        position1.z = data.position[2];
        transform.position = position1;
    }
    void OnValidate (){
        playerdata data = savesystem.LoadPlayer();
        Vector3 position1;
        position1.x = data.position[0];
        position1.y = data.position[1];
        position1.z = data.position[2];
        transform.position = position1;
    }
    void FixedUpdate (){
        savesystem.SavePlayer(this);
    }
}
