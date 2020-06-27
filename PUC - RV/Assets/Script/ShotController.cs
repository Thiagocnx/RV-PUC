using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VRTK;
using VRTK.Examples;
//using System.IO.Ports;

public class ShotController : MonoBehaviour
{
    public GameObject tiro;
    public GameObject posTiro;
    private VRTK_InteractableObject longGun;
    public WeaponRecoil recoil;
    public AudioSource audio;
    //SerialPort serialPortRight = new SerialPort("COM9",9600);
    //SerialPort serialPortLeft = new SerialPort("COM6", 9600);


    // Start is called before the first frame update
    void Start()
    {
        longGun = GetComponent<VRTK_InteractableObject>();
        //Setup Bluetooth Esquerda
        //serialPortLeft.Open();
        //serialPortLeft.ReadTimeout = 100;

        //Setup Bluetooth Dereita
        //serialPortRight.Open();
        //serialPortRight.ReadTimeout = 100;
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
    }
    void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1)  && !longGun.isGrabbable)
        {
            Shot();
            
        }

    }
    void Shot()
    {
        
        var bullet = (GameObject)Instantiate(tiro, posTiro.transform.position, posTiro.transform.rotation);
        recoil.Fire();
        audio.Play();
        // MotorOn();
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 10;
        Destroy(bullet, 2.0f);

    }
    //public void MotorOn()
    //{
     //   if (serialPortLeft.IsOpen)
     //   {
     //       serialPortLeft.Write("a");
     //   }

     //   if (serialPortRight.IsOpen)
     //   {
     //       serialPortRight.Write("a");
     //   }
        
    //}

}
