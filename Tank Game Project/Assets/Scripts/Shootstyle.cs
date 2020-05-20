using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootstyle : MonoBehaviour
{
    public int m_PlayerNumber = 1;              
    public Rigidbody m_Shell;                  
    public Transform m_FireTransform;
    

    public float m_MinLaunchForce = 15f;        
    public float m_MaxLaunchForce = 30f;        
    public float m_MaxChargeTime = 0.75f;

    private string m_FireButton;                
    private float m_CurrentLaunchForce;         
    private float m_ChargeSpeed;               
    private bool m_Fired;

    // Start is called before the first frame update
    void Start()
    {
        m_FireButton = "Fire" + m_PlayerNumber;
        m_ChargeSpeed = (m_MaxLaunchForce - m_MinLaunchForce) / m_MaxChargeTime;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Fire()
    {
        m_Fired = true;

        Rigidbody shellInstance =
            Instantiate(m_Shell, m_FireTransform.position, m_FireTransform.rotation) as Rigidbody;

        shellInstance.velocity = m_CurrentLaunchForce * m_FireTransform.forward; ;
           
    }
}
