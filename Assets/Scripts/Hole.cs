using UnityEngine;

public class Hole : MonoBehaviour {

    public GameObject mole = null;
    public int numberOfObjects = 9;
    public float radius = 35f;
    public float aliveTime = 1;
    public int intervalMin = 4;
    public int intervalMax = 15;

    // Use this for initialization
    void Start()
    {
        Invoke("Spawn", Random.Range(intervalMin, intervalMax));
    }
    void Spawn()
    {
        
        GameObject g = (GameObject)Instantiate(mole, transform.position, Quaternion.identity);
        Destroy(g, aliveTime);
        Invoke("Spawn", Random.Range(intervalMin, intervalMax));

        /*
    for (int i = 0; i < numberOfObjects; i++)
    {
        float angle = i * Mathf.PI * 2 / numberOfObjects;
        Vector3 pos = new Vector3(Mathf.Cos(angle) + 1, Mathf.Sin(angle), 0) * radius;
        GameObject g = (GameObject)Instantiate(mole, pos, Quaternion.identity);
        Destroy(g, aliveTime);
    }
    */
        Invoke("Spawn", Random.Range(intervalMin, intervalMax));
    }
}
