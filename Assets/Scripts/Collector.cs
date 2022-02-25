using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") || collision.CompareTag("Heal"))
            Destroy(collision.gameObject);

        if (collision.CompareTag("Player"))
        {
            float delta;
            if (gameObject.name == "Left Collector") delta = -1.2f;
            else delta = 1.2f;
            collision.gameObject.transform.position = new Vector3(
                transform.position.x - delta, collision.gameObject.transform.position.y,
                collision.gameObject.transform.position.z);

        }
    }
}
