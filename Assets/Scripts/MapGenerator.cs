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

    /*10�ǰ|48�t
    �u�ǰ|6
    �ƾǤu�{�P���Ƥu�{�t�B�g��u�{�t�B�u�~�u�{�P�޲z�t�B��ؤu�{�t�B���һP�w���åͤu�{�t�B�u�~�]�p�t

    ���z���q�ǰ|4
    ����u�{�t�B�Ҩ�u�{�t�B���q�u�{�t�B�෽�P�N��Žդu�{�t
    
    �q���P��T�ǰ|6
    �q���u�{�t�B�q�l�u�{�t�B��T�u�{�t�B�q�l�u�{�t�B�q���P�q�T�u�{�t�B�b����u�{�t
    
    ���ƾǰ|5
    �y��ή��v�u�{�t�B�q�T�u�{�t�B��B�޳N�t�B�����u�{�t�B���Ƹ�T��ިt
    
    ����ǰ|5
    ���~�Ͳ��P�޲z�t�B�������~��Ǩt�B�����i�ިt�B���v�ͪ��޳N�t�B���v���Ҥu�{�t
    
    �ӷ~���z�ǰ|5
    �|�p��T�t�B���ĸ�T�t�B�]�F�|�Ȩt�B�[���޲z�t�B���z�ӰȨt
    
    �޲z�ǰ|8
    ��T�޲z�t�B�B�w�޲z�t�B��P�P�y�q�޲z�t�B��ڥ��~�t�B���~�޲z�t�B���I�޲z�P�O�I�t�B���Ĩt�B�]�Ⱥ޲z�t
    
    ���v�ӰȾǰ|4
    ��B�޲z�t�B�Ӱȸ�T���Ψt�B������޲z�t�B���v�𶢺޲z�t
    
    �H����|�ǰ|2
    �H�O�귽�o�i�t�B��ƳзN���~�t
    
    �~�y�ǰ|3
    ���έ^�y�t�B���Τ�y�t�B���μw�y�t
    */
}
