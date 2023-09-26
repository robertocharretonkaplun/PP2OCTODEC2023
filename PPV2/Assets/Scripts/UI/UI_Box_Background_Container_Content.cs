using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Box_Background_Container_Content : MonoBehaviour
{
  public TMP_Text content;

  public List<string> Dialogs;
  public int index = 0;
  public void nextDialog()
  {
    if (index == Dialogs.Count)
    {
      index = 0;
      content.text = Dialogs[index];
      return;
    }
    else
    {
      index++;
    }
    content.text = Dialogs[index];
  }

  // Start is called before the first frame update
  void Start()
  {
    //content = GetComponent<TMP_Text>();
    content.text = Dialogs[index];
  }

  // Update is called once per frame
  void Update()
  {

  }
}
