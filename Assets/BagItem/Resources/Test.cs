using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
            Drug dg = new Drug();
            if (Input.GetKey(KeyCode.E))
            {
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    dg.resID = ResName.lred;
                    BagAction.Instance.addAlgorithom(dg, dg.resID);
                }
                if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    dg.resID = ResName.lblue;
                    BagAction.Instance.addAlgorithom(dg, dg.resID);
                }
                if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    dg.resID = ResName.lyellow;
                    BagAction.Instance.addAlgorithom(dg, dg.resID);
                }
            }
            Equipment eq = new Equipment();
            if (Input.GetKey(KeyCode.Q))
            {
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    eq.resID = ResName.sword;
                    BagAction.Instance.addAlgorithom(eq, eq.resID);
                }
                if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    eq.resID = ResName.helmet;
                    BagAction.Instance.addAlgorithom(eq, eq.resID);
                }
                if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    eq.resID = ResName.cloth;
                    BagAction.Instance.addAlgorithom(eq, eq.resID);
                }
            }
        


       
	}
}
