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

    /*17��32���I
    �Z�L�� ML
    �s�Y�s���N���C�ְϥ𮧰�

    ���t�� LG
    ���¤ѥx�s�B���ӷ��Y���ԹD

    ���@�� MN
    ���@���U��

    �j��� DS
    ���K����a�ͺA����B�q�j�C�֥@��

    �p��� XG
    �b��A��

    ��s�� FS
    �êZ���a���N��Ƥ��ߡB�j�F������N����

    ���Q�� NS
    �g�c���

    �мd�� TL
    ���Y�q�B��@�ɦa������

    �X�z�� CJ1
    �X�z��������

    �e��� CJ2
    �������߹Ϯ��]�`�]�B�j�|�կ�ŹD���ѽ�

    ���s�� GS
    �j����B�����^�����]�x��B�̶L�wKW2�B�ؤs���H�[���x
    �����@�ءB��s����B��l�W

    �Q�L�� YC
    �����y�歵�֤���/������B��G���N�S��

    �e���� QJ
    �զ��ʤH�f�d��

    �s���� XX
    �p����B���R�q�� �����Ƴ�

    �T���� SM
    �¤T�������B�T��c

    ����� ZY
    �G�T���ϡB������

    ������ AT
    ��������������Y
    */
}
