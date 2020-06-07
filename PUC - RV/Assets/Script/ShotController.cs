using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VRTK;
using VRTK.Examples;

public class ShotController : MonoBehaviour
{
    public GameObject tiro;
    public GameObject posTiro;
    private VRTK_InteractableObject longGun;
    
    // Start is called before the first frame update
    void Start()
    {
        longGun = GetComponent<VRTK_InteractableObject>();
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
    }
    void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) && !longGun.isGrabbable)
        {
            Shot();
            
        }

    }
    void Shot()
    {
        
        var bullet = (GameObject)Instantiate(tiro, posTiro.transform.position, posTiro.transform.rotation);
        //Commands to control vibration here, first moment
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 10;
        Destroy(bullet, 2.0f);

    }
}
