using Firebase.Firestore;
using UnityEngine;

[FirestoreData]
public class Card
{
    [FirestoreProperty] public string ID { get; set; }
    [FirestoreProperty] public string Character { get; set; }
    [FirestoreProperty] public int Cost { get; set; }
    [FirestoreProperty] public string Attribute { get; set; }
    [FirestoreProperty] public int Power { get; set; }
    [FirestoreProperty] public int Counter { get; set; }
    [FirestoreProperty] public string Color { get; set; }
    [FirestoreProperty] public string[] Type { get; set; }
    [FirestoreProperty] public string Effect { get; set; }
    [FirestoreProperty] public string CardSet { get; set; }

  public Card() { }

  public Card(string id, string character, int cost, string attribute, int power, int counter, string color, string[] type, string effect, string cardset)
  {
        ID = id;
        Character = character;
        Cost = cost;
        Attribute = attribute;
        Power = power;
        Counter = counter;
        Color = color;
        Type = type;
        Effect = effect;
        CardSet = cardset;
    }
}
