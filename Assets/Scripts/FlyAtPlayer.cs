using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float FlyingSpeed = 5f;
    Vector3 playerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }

    void OnEnable()
    {
        playerPosition = player.transform.position;
    }

    // void Start()
    // {
    //     playerPosition = player.transform.position;
    // }


    void Update()
    {
        MovePlayer();
        DestroyWhenReached();
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }

    void MovePlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * FlyingSpeed);
    }
}
