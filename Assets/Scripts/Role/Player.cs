using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Role {

    void Awake()
    {
        Role.Player = this;
        moveSpeed = 10;
    }
}
