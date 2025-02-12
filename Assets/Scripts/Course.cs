
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Course : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    [SerializeField] float vitesse;

    // Start is called before the first frame update
    void Start()
    {
        vitesse = Random.Range(1f, 5f);
        direction = Vector3.forward;

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(direction.normalized * vitesse * Time.deltaTime, Space.Self);

        if (transform.position.x > 5f)
        {
            Debug.Log(gameObject.name);
        }
}

}




