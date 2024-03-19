using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teletransporte : MonoBehaviour
{
    private bool tieneItem;

    void OnTriggerEnter(Collider c){
        if (c.gameObject.CompareTag("Player")){
            bool tieneItem = c.gameObject.GetComponent<Inventario>().HasItem("GemaAzul");
            if (tieneItem){
                SceneManager.LoadScene("SceneEnd");
            }
        }
    }
}
