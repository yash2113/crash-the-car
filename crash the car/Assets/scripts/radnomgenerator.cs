using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radnomgenerator : MonoBehaviour
{
    public GameObject Barrel;
    public GameObject Crate;
    public GameObject Barrier;
    public GameObject Cone;
    public GameObject Spool;
    public GameObject Rock;
    public int xPos;
    public int zPos;
    public int objectToGenerate;
    public int objectQuantity;
    public int xPosRandom1,xPosRandom2;
    public int zPosRandom1,zPosRandom2;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GenerateRandom());
    }


    IEnumerator GenerateRandom()
    {
        while(objectQuantity<7)
        {
            objectToGenerate=Random.Range(1,7);
            xPos=Random.Range(xPosRandom1,xPosRandom2);
            zPos = Random.Range(zPosRandom1,zPosRandom2);
            if(objectToGenerate==1)
            {
                Instantiate(Barrel,new Vector3(xPos,27.35f,zPos),Quaternion.identity);
            }
            if (objectToGenerate == 2)
            {
                Instantiate(Crate, new Vector3(xPos, 27.35f, zPos), Quaternion.identity);
            }
            if (objectToGenerate == 3)
            {
                Instantiate(Barrier, new Vector3(xPos, 27.35f, zPos), Quaternion.identity);
            }
            if (objectToGenerate == 4)
            {
                Instantiate(Cone, new Vector3(xPos, 27.35f, zPos), Quaternion.identity);
            }
            if (objectToGenerate == 5)
            {
                Instantiate(Spool, new Vector3(xPos, 27.35f, zPos), Quaternion.identity);
            }
            if (objectToGenerate == 6)
            {
                Instantiate(Spool, new Vector3(xPos, 27.35f, zPos), Quaternion.identity);
            }
            yield return new WaitForSeconds(0.1f);
            objectQuantity += 1;
        }





    }

   
}
