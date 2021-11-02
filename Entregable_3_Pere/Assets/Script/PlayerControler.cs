using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {


        RotationToDirection(KeyCode.R, new Vector3(45, 0, 45));

        Escala(KeyCode.W, Vector3.one*2);
    }

    public void Escala(KeyCode Key, Vector3 escalar)
    {
        if (Input.GetKeyDown(Key))
        {
            transform.localScale += escalar;
        }

    }
    public void RotationToDirection(KeyCode Key, Vector3 rotar)
    {
        if (Input.GetKeyDown(Key))
        {
            transform.rotation *= Quaternion.Euler(rotar);
        }
    }

}
