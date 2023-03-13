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

    /*10�ǰ|48�t
    �u�ǰ|
    �ƾǤu�{�P���Ƥu�{�t�B�g��u�{�t�B�u�~�u�{�P�޲z�t�B��ؤu�{�t�B���һP�w���åͤu�{�t�B�u�~�]�p�t

    ���z���q�ǰ|
    ����u�{�t�B�Ҩ�u�{�t�B���q�u�{�t�B�෽�P�N��Žդu�{�t
    
    �q���P��T�ǰ|
    �q���u�{�t�B�q�l�u�{�t�B��T�u�{�t�B�q�l�u�{�t�B�q���P�q�T�u�{�t�B�b����u�{�t
    
    ���ƾǰ|
    �y��ή��v�u�{�t�B�q�T�u�{�t�B��B�޳N�t�B�����u�{�t�B���Ƹ�T��ިt
    
    ����ǰ|
    ���~�Ͳ��P�޲z�t�B�������~��Ǩt�B�����i�ިt�B���v�ͪ��޳N�t�B���v���Ҥu�{�t
    
    �ӷ~���z�ǰ|
    �|�p��T�t�B���ĸ�T�t�B�]�F�|�Ȩt�B�[���޲z�t�B���z�ӰȨt
    
    �޲z�ǰ|
    ��T�޲z�t�B�B�w�޲z�t�B��P�P�y�q�޲z�t�B��ڥ��~�t�B���~�޲z�t�B���I�޲z�P�O�I�t�B���Ĩt�B�]�Ⱥ޲z�t
    
    ���v�ӰȾǰ|
    ��B�޲z�t�B�Ӱȸ�T���Ψt�B������޲z�t�B���v�𶢺޲z�t
    
    �H����|�ǰ|
    �H�O�귽�o�i�t�B��ƳзN���~�t
    
    �~�y�ǰ|
    ���έ^�y�t�B���Τ�y�t�B���μw�y�t
    */
}
