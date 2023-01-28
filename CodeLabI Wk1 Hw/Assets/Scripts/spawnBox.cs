using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBox : MonoBehaviour
{
    public GameObject objToSpawn;
    public float rateOfSpawn;
    private Bounds bounds;
    private float objX;
    private float objY;
    private float objZ;

    private GameObject spawnHolder;
    public Material goodMaterial;
    public Material badMaterial;

    public List<GameObject> objGood;
    public List<GameObject> objBad;

    // Start is called before the first frame update
    void Start()
    { 
        bounds = objToSpawn.GetComponent<Collider>().bounds;

        spawnHolder = new GameObject();
    }

    // Update is called once per frame
    void Update()
    {
        objX = Random.Range(-bounds.extents.x, bounds.extents.x);
        objY = Random.Range(0, bounds.extents.y);
        objZ = Random.Range(-bounds.extents.z, bounds.extents.z);
        if (objGood.Count<50)
        {
            Invoke("Spawn", rateOfSpawn);
        }
        else if (objBad.Count<50)
        {
            Invoke("SpawnBad", rateOfSpawn);
        }
    }

    void Spawn()
    {
        GameObject newObj = GameObject.CreatePrimitive((PrimitiveType.Cube));
        newObj.GetComponent<Renderer>().material = goodMaterial;
        newObj.transform.position = new  (objX, objY, objZ);
        objGood.Add(newObj);

        newObj.transform.parent = spawnHolder.transform;
    }
    
    void SpawnBad()
    {
        GameObject newObj2 = GameObject.CreatePrimitive((PrimitiveType.Cube));
        newObj2.GetComponent<Renderer>().material = badMaterial;
        newObj2.transform.position = new  (objX, objY, objZ);
        objBad.Add(newObj2);

        newObj2.transform.parent = spawnHolder.transform;
    }

    public bool checkListGood(GameObject col)
    {
        if (objGood.Contains(col))
        {
            return true; 
        }

        return false;
    }
    
    public bool checkListBad(GameObject col)
    {
        if (objBad.Contains(col))
        {
            return true; 
        }

        return false;
    }
}
