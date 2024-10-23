using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NhanDame : MonoBehaviour
{
    public int hp = 10;
    public virtual bool IsDead()
    {
        return this.hp <= 0;
    }
    public virtual void Receiver(int damage)
    {
        this.hp -= damage;
        if (this.IsDead())
        {
            Debug.Log("Xe Hong Roi");
            SceneManager.LoadScene(0);
        }

    }
}
