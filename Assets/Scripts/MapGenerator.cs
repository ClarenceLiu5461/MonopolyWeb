using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    Dictionary<int, GameObject> ObjectList = new Dictionary<int, GameObject>();
    public GameObject Square;
    public Transform GeneratorPoint;
    public int Distance;
    public int CollegeNum;
    //Colleges
    public int EngineeringCollege;
    public int SmartMechatronicsCollege;
    public int ElectricalEngineeringAndInformaticsCollege;
    public int MaritimeCollege;
    public int HydrosphereCollege;
    public int BusinessIntelligenceCollege;
    public int ManagementCollege;
    public int OceanBusinessCollege;
    public int HumanitiesAndSocialSciencesCollege;
    public int ForeignLanguagesCollege;
    public Color[] Color_list;

    void Start()
    {
        MapGenerate();
        ChangeColor();
    }

    public void MapGenerate()
    {
        for (int i = 0; i < CollegeNum; i++)
        {
            //Add instantiated Squares into ObjectList
            ObjectList.Add(i,Instantiate(Square, GeneratorPoint.position, Quaternion.identity));
            if (i < (CollegeNum / 4))
            {
                GeneratorPoint.position -= new Vector3(Distance, 0, 0);
            }
            else if (i < (CollegeNum / 2))
            {
                GeneratorPoint.position += new Vector3(0, Distance, 0);
            }
            else if (i < (CollegeNum / 4) * 3)
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
        for (int id = 0; id<CollegeNum; id++)
        {
            if (ObjectList.ContainsKey(id))
            {
                //ObjectList[id].gameObject.GetComponent<SpriteRenderer>().color = Color_list[0];
            }
        }

    }

    void Update()
    {
        
    }

    /*10學院48系
    工學院
    化學工程與材料工程系、土木工程系、工業工程與管理系、營建工程系、環境與安全衛生工程系、工業設計系

    智慧機電學院
    機械工程系、模具工程系、機電工程系、能源與冷凍空調工程系
    
    電機與資訊學院
    電機工程系、電子工程系、資訊工程系、電子工程系、電腦與通訊工程系、半導體工程系
    
    海事學院
    造船及海洋工程系、電訊工程系、航運技術系、輪機工程系、海事資訊科技系
    
    水圈學院
    漁業生產與管理系、水產食品科學系、水產養殖系、海洋生物技術系、海洋環境工程系
    
    商業智慧學院
    會計資訊系、金融資訊系、財政稅務系、觀光管理系、智慧商務系
    
    管理學院
    資訊管理系、運籌管理系、行銷與流通管理系、國際企業系、企業管理系、風險管理與保險系、金融系、財務管理系
    
    海洋商務學院
    航運管理系、商務資訊應用系、供應鏈管理系、海洋休閒管理系
    
    人文社會學院
    人力資源發展系、文化創意產業系
    
    外語學院
    應用英語系、應用日語系、應用德語系
    */
}
