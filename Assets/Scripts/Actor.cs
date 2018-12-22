using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Actor : MonoBehaviour
{

    public enum HandState
    {
        DONT_DECIDE,//まだ手を決めていない
        FINISH_DECIDE,//ちょうど手を決め終わった
        ACTION,
    }
    public HandState State { get; set; }

    //グーとかチョキとか。拡張性をつけるためenumで
    public enum Actions
    {
        Gu,
        Choki,
        Par,
        Unknown,
        Error,
    }

    public int HP;
    public int AttackGu;
    public int AttackChoki;
    public int AttackPar;

    protected void Start()
    {
        HP = 100; AttackGu = 7; AttackChoki = 13; AttackPar = 17;
    }

    //g : グー、c : チョキ、p : パー
    public Actions Action = Actions.Unknown;

    //この中でm_handを決定してm_stateをFINISH_DECIDEにする。
    public abstract void DecideHand();

}
