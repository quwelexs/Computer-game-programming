using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Налаштування руху")]
    // Швидкість задається в інспекторі (public або [SerializeField])
    public float speed = 5.0f;

    [Header("Налаштування кольорів")]
    public Color idleColor = Color.white; // Колір, коли стоїмо
    public Color movingColor = Color.red; // Колір, коли рухаємось

    private MeshRenderer myRenderer;

    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();

        if (myRenderer != null)
        {
            myRenderer.material.color = idleColor;
        }
    }

    void Update()
    {
        Vector3 moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            moveDirection += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDirection += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveDirection += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDirection += Vector3.right;
        }

        transform.position += moveDirection * speed * Time.deltaTime;

        if (myRenderer != null)
        {
            if (moveDirection != Vector3.zero)
            {
                myRenderer.material.color = movingColor;
            }
            else
            {
                myRenderer.material.color = idleColor;
            }
        }
    }
}