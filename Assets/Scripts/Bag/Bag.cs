using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bag : MonoBehaviour {


    public static Bag Instance;
	public Dictionary<string,GameObject> bagItemDic = new Dictionary<string, GameObject>();

	public static Vector2 initPos = new Vector2 (-166, 250);

    /// <summary>
    /// 生成背包框
    /// </summary>
    /// <param name="i">第几行</param>
    /// <param name="j">第几列</param>
	/// 
	/// 
	/// 
	/// 

    void Awake()
    {
        Instance = this;
    }
    public void insBagItem(int i,int j)
    {


       GameObject g =  GameObject.Instantiate(ResourcesManager.prefabDic[ResName.bagItem],this.transform);
       Image img = g.GetComponent<Image>();
       img.sprite = new Sprite();
      


    }



    
	public void insBagItem()
	{
	
		for (int i = 0; i < 4; i++) {
		
			for (int j = 0; j < 4; j++) {
				string id = i+"-"+j+"-";//id为背包框的id
				GameObject g =  GameObject.Instantiate (ResourcesManager.prefabDic[ResName.bagItem],this.transform);
				g.GetComponent<RectTransform> ().localPosition = initPos+new Vector2(+j*110,-i*110);//改为先生成行，再生成列
                BagItem item = g.GetComponent<BagItem>();
                item.bagItemID = id;
	            
               
				bagItemDic.Add (id, g);
			}
		
		}
	}

    void Start()
    {
        
		insBagItem ();
    }

}
