using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 15f;

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Meteor>() != null)
        {
            gameObject.SetActive(false);
            other.gameObject.SetActive(false);
        }
    }
}