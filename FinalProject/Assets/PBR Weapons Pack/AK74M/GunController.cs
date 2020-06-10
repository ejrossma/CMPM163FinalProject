using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class GunController : MonoBehaviour
{
    Animator m_animator;
    
    public GameObject mainBullet;
    public float speed = 200f;

    void Start()
    {
        m_animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    public TimeManager timeManager;

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            m_animator.SetTrigger("Shoot");
            Bullet();
        }
        if(Input.GetKeyDown("z"))
        {
            m_animator.SetTrigger("Shoot");
            BulletSlow();
        }

    }

    void Bullet()
    {
        float angle = 90;
        float rotation = 90;
        GameObject instBullet = Instantiate(mainBullet, transform.position, Quaternion.identity) as GameObject;
        instBullet.transform.position = new Vector3(3.2f, 1.564f, -0.7952048f);
        instBullet.transform.rotation = Quaternion.Euler(angle, 0 , rotation);
        Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
        instBulletRigidbody.AddForce(Vector3.left * speed);

    }
    void BulletSlow()
    {
        float angle = 90;
        float rotation = 90;
        GameObject instBullet = Instantiate(mainBullet, transform.position, Quaternion.identity) as GameObject;
        instBullet.transform.position = new Vector3(3.2f, 1.564f, -0.7952048f);
        instBullet.transform.rotation = Quaternion.Euler(angle, 0 , rotation);
        Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
        instBulletRigidbody.AddForce(Vector3.left * speed);
        timeManager.DoSlowMotion();

    }
}