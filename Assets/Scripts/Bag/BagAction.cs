using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BagAction : MonoBehaviour {

    Bag bag;
    public static BagAction Instance;

    void Awake()
    {
        Instance = this;
    }
	void Start () {
        bag = Bag.Instance;
	}

    /// <summary>
    /// 添加策略
    /// </summary>
    
    public void addAlgorithom(ItemBase item,string id)//id为物品id
    {

        bool ifContain = false;//记录背包内是否存在该物品
        BagItem preBagItem = null;

        foreach (GameObject _item in bag.bagItemDic.Values) {//先寻找背包框有无该物品

            BagItem bagItem = _item.GetComponent<BagItem>();
            if (item.resID == bagItem.itemID)//存在该物品
            {
                ifContain = true;
                preBagItem = bagItem;//定位到该背包框，保存其引用
                break;
            }
        }
        if (ifContain == true)//背包内存在该物品，则数量加一
        {
            preBagItem.plusNum();

        }
        else {//背包内不存在该物品，添加该物品
            foreach (GameObject _item in bag.bagItemDic.Values)//添加时需要遍历背包，寻找第一个框为空的格子存放该物品
            {
                BagItem bagItem = _item.GetComponent<BagItem>();

                if (bagItem.itemID == null)
                {
                    //Debug.Log(bagItem.itemID);
                  
                    bagItem.itemID = item.resID;
                    bagItem.addItem(item);
                    break;

                }
            }
        
        }
            
      }
}
