using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Role : MonoBehaviour {

    public static Role Player;


    public int hp { get; set; }
    public int mp { get; set; }
    public int moveSpeed { get; set; }
    public int exp { get; set; }
    public int atk { get; set; }
    public int defind { get; set; }


    public void move(Vector3 dir)
    {

        this.gameObject.transform.position += dir * Time.deltaTime * moveSpeed;
        
    }





}
