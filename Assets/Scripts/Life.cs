using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using TMPro;

public class Life : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The life of the player")]
    int life = 3;
    // Start is called before the first frame update


    public void Start()
    {
        if (this.tag == "P2")
        {
            GameObject.Find("player2_life").GetComponent<TextMeshPro>().text = life + "";
        }
        if (this.tag == "P1")
        {
            GameObject.Find("player1_life").GetComponent<TextMeshPro>().text = life + "";
        }
    }
    public void getHit(GameObject go)
    {
        TextMeshPro temp;
        if (go.tag == "P2")
        {
           temp = GameObject.Find("player2_life").GetComponent<TextMeshPro>();
        }
        else 
        {
            temp = GameObject.Find("player1_life").GetComponent<TextMeshPro>();
        }
        int templife = Int32.Parse(temp.text);
        templife--;
        temp.text = templife + "";
        life--;
    }
    public bool isAlive()
    {
        return life>0;
    }
}
