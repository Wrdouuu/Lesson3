using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiDame : MonoBehaviour
{
    public NhanDame dameReceiver;
    public int damage = 1;
    private void Start()
    {
        this.dameReceiver = GetComponent<NhanDame>();
    }
    public void OnCollisionEnter(Collision collision)
    {
        this.ColliderSendDame(collision);
    }
    public virtual void ColliderSendDame(Collision collision)
    {
        if (dameReceiver != null)
        {
            dameReceiver.Receiver(damage);
            Debug.Log("tru mau");
        }
        else
        {
            return;
        }
    }
}
