using UnityEngine;

public class Meteor : MonoBehaviour
{
    public float speed = 2f;
    private Vector3 moveDirection;

    public void SetTarget(Vector3 playerPosition)
    {
        moveDirection = (playerPosition - transform.position).normalized;

        Destroy(gameObject, 45f);
    }

    void Update()
    {
        transform.position += moveDirection * speed * Time.deltaTime;
    }
}