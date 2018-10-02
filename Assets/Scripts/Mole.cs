using UnityEngine;

public class Mole : MonoBehaviour {

    public GameObject onHit = null;
    public static int killedMole = 0;
    void OnMouseDown()
    {
        GameObject g = (GameObject)Instantiate(onHit,
                                                transform.position,
                                                Quaternion.identity);
        killedMole++;
        Destroy(g, 0.2f);
    }
}
