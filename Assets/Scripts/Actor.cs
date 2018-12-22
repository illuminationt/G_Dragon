using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour {
    
    public enum State
    {

    }


    [SerializeField] protected int m_HP;
    [SerializeField] protected int[] m_attack;
    protected char m_hand;

    protected virtual void DecideHand() { }
    

}
