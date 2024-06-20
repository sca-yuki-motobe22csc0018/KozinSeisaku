using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDefault : MonoBehaviour
{
    bool moveStart;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        moveStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!moveStart)
        {
            transform.position -= new Vector3(0, 9.8f * 2 * Time.deltaTime, 0);
            return;
        }
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        //Debug.Log(moveStart);


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            moveStart = true;
        }
    }
}
