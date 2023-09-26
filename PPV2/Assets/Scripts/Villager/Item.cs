using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Item_Effect
{
  NONE = 0, 
  CONSUMIBLE = 1, 
  DAMAGE = 2
}

public class Item : MonoBehaviour
{
  public string Name;
  public Sprite Image;
  public Item_Effect Effect;

  public Item() { }

  public Item(string _name)
  {
    Name = _name;
    //Image = GetComponent<Sprite>();
    Effect = Item_Effect.NONE;
  }

  public Item(string _name, Sprite _image, Item_Effect _effect)
  {
    name = _name;
    Name = _name;
    Image = _image;
    _effect = Effect;
  }
  // Start is called before the first frame update
  void Start()
  {
  }

  // Update is called once per frame
  void Update()
  {

  }
}
