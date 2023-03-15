using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    Dictionary<int, GameObject> ObjectList = new Dictionary<int, GameObject>();
    public GameObject Square;
    public Transform SquaresParent;
    public Transform GeneratorPoint;
    public int Distance;
    public int DepartmentNum;
    //Colleges
    public int EC;
    public int SMC;
    public int EEAIC;
    public int MC;
    public int HC;
    public int BIC;
    public int MMC;
    public int OBC;
    public int HASSC;
    public int FLC;
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
            ObjectList.Add(i,Instantiate(Square, GeneratorPoint.position, Quaternion.identity,SquaresParent));
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
                if (id < EC)
                {
                    Area = 0;
                }
                else if (id < EC + SMC)
                {
                    Area = 1;
                }
                else if (id < EC + SMC + EEAIC)
                {
                    Area = 2;
                }
                else if (id < EC + SMC + EEAIC + MC)
                {
                    Area = 3;
                }
                else if (id < EC + SMC +EEAIC + MC +HC)
                {
                    Area = 4;
                }
                else if (id < EC + SMC + EEAIC + MC + HC +BIC)
                {
                    Area = 5;
                }
                else if (id < EC + SMC + EEAIC + MC + HC + BIC + MMC)
                {
                    Area = 6;
                }
                else if (id < EC + SMC + EEAIC + MC + HC + BIC + MMC + OBC)
                {
                    Area = 7;
                }
                else if (id < EC + SMC + EEAIC + MC + HC + BIC + MMC + OBC + HASSC)
                {
                    Area = 8;
                }
                else if (id < EC + SMC + EEAIC + MC + HC + BIC + MMC + OBC +HASSC +FLC)
                {
                    Area = 9;
                }
                ObjectList[id].gameObject.GetComponent<SpriteRenderer>().color = Color_list[Area];
            }
        }
    }

    void Update()
    {
        
    }

    /*10學院48系
    工學院6
    化學工程與材料工程系、土木工程系、工業工程與管理系、營建工程系、環境與安全衛生工程系、工業設計系

    智慧機電學院4
    機械工程系、模具工程系、機電工程系、能源與冷凍空調工程系
    
    電機與資訊學院6
    電機工程系、電子工程系、資訊工程系、電子工程系、電腦與通訊工程系、半導體工程系
    
    海事學院5
    造船及海洋工程系、電訊工程系、航運技術系、輪機工程系、海事資訊科技系
    
    水圈學院5
    漁業生產與管理系、水產食品科學系、水產養殖系、海洋生物技術系、海洋環境工程系
    
    商業智慧學院5
    會計資訊系、金融資訊系、財政稅務系、觀光管理系、智慧商務系
    
    管理學院8
    資訊管理系、運籌管理系、行銷與流通管理系、國際企業系、企業管理系、風險管理與保險系、金融系、財務管理系
    
    海洋商務學院4
    航運管理系、商務資訊應用系、供應鏈管理系、海洋休閒管理系
    
    人文社會學院2
    人力資源發展系、文化創意產業系
    
    外語學院3
    應用英語系、應用日語系、應用德語系
    */
}
