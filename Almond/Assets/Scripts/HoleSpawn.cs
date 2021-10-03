using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleSpawn : MonoBehaviour
{

    public float time = 20f;
    public GameObject hole;
    public AudioSource source;

    void Start() {

        source = GetComponent<AudioSource> ();

    }

    void Update()
    {
        if (time > 0)
        {

            time -= Time.deltaTime;

        }

        else {
            int rand = Random.Range(0, 5);
            Debug.Log(rand.ToString());
            if (rand == 0)
            {
                source.Play();
                Invoke("Sound", 4);
                time = 15f;
            }
            else {
                time = 15f;
            }
           

        }
    }

    void Sound() {

        Instantiate(hole);

    }

}
