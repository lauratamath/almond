using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleDestroy : MonoBehaviour
{
    float life = 3f;
    void Update()
    {
        life -= Time.deltaTime;
        if (life < 0) {

            Destroy(this.gameObject);

        }
    }
}
