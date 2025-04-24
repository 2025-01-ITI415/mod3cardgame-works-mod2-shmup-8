using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum eCardState { drawpile, mine, target, discard }
public class CardGolf : Card
{
    [Header("Dynamic: CardGolf")]
    public eCardState state = eCardState.drawpile;


    public List<CardGolf> hiddenBy = new List<CardGolf>();
    public int layoutID;
    public JsonLayoutSlot layoutSlot;

    override public void OnMouseUpAsButton()
    {
        Golf.CARD_CLICKED(this);
        base.OnMouseUpAsButton();// b
    }

}
