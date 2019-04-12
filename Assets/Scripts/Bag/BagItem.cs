using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagItem : MonoBehaviour {

    Text numLabel;
    int num;
    /// <summary>
    /// 描述的是物品的ID
    /// </summary>
    public string itemID { get; set; }
    /// <summary>
    /// 框的ID
    /// </summary>
    public string bagItemID { get; set; }
    void Awake()
    {
        numLabel = this.transform.Find("00").GetComponent<Text>();

    }

    public void addItem(ItemBase item)
    {
        num = 1;
        numLabel.text = num+"";
        GameObject G = GameObject.Instantiate(ResourcesManager.prefabDic[item.resID], this.transform);



    
        
    }

    public void plusNum()
    {

        num+=1;
        numLabel.text = num + "";
    }



}
