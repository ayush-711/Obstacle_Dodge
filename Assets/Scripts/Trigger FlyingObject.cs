using UnityEngine;

public class TriggerFlyingObject : MonoBehaviour
{
    [SerializeField] GameObject FlyingObject ;
    [SerializeField] GameObject FlyingObject1 ;
    [SerializeField] GameObject FlyingObject2 ;
    [SerializeField] GameObject FlyingObject3 ;
    [SerializeField] GameObject FlyingObject4 ;

    
    private void OnTriggerEnter(Collider other) {

        if(other.gameObject.tag == "Player"){
            FlyingObject.SetActive(true);
            FlyingObject1.SetActive(true);
            FlyingObject2.SetActive(true);
            FlyingObject3.SetActive(true);
            FlyingObject4.SetActive(true);
            Destroy(gameObject);
        }
    }
    }


