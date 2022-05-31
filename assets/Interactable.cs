using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
public class Interactable : MonoBehaviour
{
    public GameObject uiObject;
    public bool t = false; 


    void Start() {
        uiObject.SetActive(false);
    }
    void Update() {
        if(Input.GetKeyDown("1") && t==true) {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("task 1");
        }
        else if(Input.GetKeyDown("2") && t==true) {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("task2");
        }
        else if(Input.GetKeyDown("3") && t==true) {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("task3");
        }
        else if(Input.GetKeyDown("4") && t==true) {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("task4");
        }
        else if(Input.GetKeyDown("9")){
            Application.Quit();
        }
    }
    void OnTriggerEnter(Collider player) {
        if (player.gameObject.tag == "Player") {
            uiObject.SetActive(true);
            t=true;
    }}

    void OnTriggerExit(Collider player) {
        if(player.gameObject.tag == "Player") {
            uiObject.SetActive(false);
            t=false;
        }
    }
}
