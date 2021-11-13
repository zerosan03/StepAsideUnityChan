using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private GameObject Maincamera;
    private float cameraset;
    private float itemset;
    // Start is called before the first frame update
    void Start()
    {
        this.Maincamera = GameObject.Find("Main Camera");
        this.itemset = this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        this.cameraset = Maincamera.transform.position.z;

        if (cameraset > itemset)
        {
            Destroy(gameObject);
        }
    }
}
