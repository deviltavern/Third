using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RockerItem : ButtonBase, IPointerDownHandler, IPointerUpHandler　　    
{

	// Use this for initialization
    Transform parent;
    bool allowMove = false;
	void Start () {

        parent = this.transform.parent;
	}
    

	
	// Update is called once per frame
    public Vector3 dir;
	void Update () {

        if (allowMove == true)
        {
            this.transform.position = Input.mousePosition;

            dir = Vector3.Normalize(this.GetComponent<RectTransform>().localPosition - new Vector3());
            dir = new Vector3(dir.x, 0, dir.y);

            Role.Player.move(dir);
          
        }



	}

    public override void OnClickBtn()
    {


        Debug.Log("点击了这个按钮");



    }




    public void OnPointerDown(PointerEventData eventData)
    {
        allowMove = true;
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        allowMove = false;

        this.GetComponent<RectTransform>().localPosition = new Vector3();
    }
}
