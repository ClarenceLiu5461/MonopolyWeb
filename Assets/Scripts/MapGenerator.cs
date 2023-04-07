using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public static Dictionary<int, GameObject> ObjectList = new Dictionary<int, GameObject>();
    public GameObject Square;
    public Transform SquaresParent;
    public Transform GeneratorPoint;
    public int Distance;
    public int DepartmentNum;
    //Districts
    public int ML;
    public int LG;
    public int MN;
    public int DS;
    public int XG;
    public int FS;
    public int NS;
    public int TL;
    public int CJ1;
    public int CJ2;
    public int GS;
    public int YG;
    public int QJ;
    public int XX;
    public int SM;
    public int ZY;
    public int AT;

    public Color[] Color_list;

    void Start()
    {
        MapGenerate();
        ChangeColor();
    }

    public void MapGenerate()
    {
        for (int i = 0; i < DepartmentNum; i++)
        {
            //Add instantiated Squares into ObjectList
            ObjectList.Add(i, Instantiate(Square, GeneratorPoint.position, Quaternion.identity, SquaresParent));
            if (i < (DepartmentNum / 4))
            {
                GeneratorPoint.position -= new Vector3(Distance, 0, 0);
            }
            else if (i < (DepartmentNum / 2))
            {
                GeneratorPoint.position += new Vector3(0, Distance, 0);
            }
            else if (i < (DepartmentNum / 4) * 3)
            {
                GeneratorPoint.position += new Vector3(Distance, 0, 0);
            }
            else
            {
                GeneratorPoint.position -= new Vector3(0, Distance, 0);
            }
        }
    }

    public void ChangeColor()
    {
        int Area = 0;
        for (int id = 0; id < DepartmentNum; id++)
        {
            if (ObjectList.ContainsKey(id))
            {
                if (id < ML)
                {
                    Area = 0;
                }
                else if (id < ML + LG)
                {
                    Area = 1;
                }
                else if (id < ML + LG + MN)
                {
                    Area = 2;
                }
                else if (id < ML + LG + MN + DS)
                {
                    Area = 3;
                }
                else if (id < ML + LG + MN + DS + XG)
                {
                    Area = 4;
                }
                else if (id < ML + LG + MN + DS + XG + FS)
                {
                    Area = 5;
                }
                else if (id < ML + LG + MN + DS + XG + FS + NS)
                {
                    Area = 6;
                }
                else if (id < ML + LG + MN + DS + XG + FS + NS + TL)
                {
                    Area = 7;
                }
                else if (id < ML + LG + MN + DS + XG + FS + NS + TL + CJ1)
                {
                    Area = 8;
                }
                else if (id < ML + LG + MN + DS + XG + FS + NS + TL + CJ1 + CJ2)
                {
                    Area = 9;
                }
                else if (id < ML + LG + MN + DS + XG + FS + NS + TL + CJ1 + CJ2 +GS)
                {
                    Area = 10;
                }
                else if (id < ML + LG + MN + DS + XG + FS + NS + TL + CJ1 + CJ2 + GS +YG)
                {
                    Area = 11;
                }
                else if (id < ML + LG + MN + DS + XG + FS + NS + TL + CJ1 + CJ2 + GS + YG + QJ)
                {
                    Area = 12;
                }
                else if (id < ML + LG + MN + DS + XG + FS + NS + TL + CJ1 + CJ2 + GS + YG + QJ + XX)
                {
                    Area = 13;
                }
                else if (id < ML + LG + MN + DS + XG + FS + NS + TL + CJ1 + CJ2 + GS + YG + QJ + XX +SM)
                {
                    Area = 14;
                }
                else if (id < ML + LG + MN + DS + XG + FS + NS + TL + CJ1 + CJ2 + GS + YG + QJ + XX + SM +ZY)
                {
                    Area = 15;
                }
                else if (id < ML + LG + MN + DS + XG + FS + NS + TL + CJ1 + CJ2 + GS + YG + QJ + XX + SM + ZY +AT)
                {
                    Area = 16;
                }
                ObjectList[id].gameObject.GetComponent<SpriteRenderer>().color = Color_list[Area];
            }
        }
    }

    /*17區32景點
    茂林區 ML
    龍頭山老鷹谷遊樂區休息區

    六龜區 LG
    神威天台山、浦來溪頭社戰道

    美濃區 MN
    美濃民俗村

    大樹區 DS
    舊鐵橋濕地生態公園、義大遊樂世界

    小港區 XG
    淨園農場

    鳳山區 FS
    衛武營國家藝術文化中心、大東文化藝術中心

    鳥松區 NS
    迷宮花園

    田寮區 TL
    石頭廟、月世界地景公園

    旗津區 CJ1
    旗津風車公園

    前鎮區 CJ2
    高雄市立圖書館總館、大魯閣草衙道摩天輪

    鼓山區 GS
    大港橋、打狗英國領事館官邸、棧貳庫KW2、壽山情人觀景台
    海岸咖啡、柴山漁港、西子灣

    鹽埕區 YC
    高雄流行音樂中心/音浪塔、駁二藝術特區

    前金區 QJ
    白色戀人貨櫃屋

    新興區 XX
    逍遙園、美麗島站 光之穹頂

    三民區 SM
    舊三塊厝車站、三鳳宮

    左營區 ZY
    果貿社區、蓮池潭

    彌陀區 AT
    彌陀漁港海岸光廊
    */
}
