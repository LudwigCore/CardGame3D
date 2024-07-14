using UnityEngine;
public class CardData : MonoBehaviour
{
    public string Name;// The name of the card
    public string Type;// what element it is
    public int Level;// The tier the card is also shows to the enemy on the back
    public string Ability;// What ability the card uses
    public float AbilityValue;// The number that the ability uses
    public float Value;// How much you need to place
    public float Turn;// How long a card lasts after placing
    public float Score;// How much score the card gives when placed
}