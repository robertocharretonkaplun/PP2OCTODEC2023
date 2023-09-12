using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Box : MonoBehaviour
{
  public UI_Box_Header_Title BoxHeaderTitle;

  public string title = "";
  public string content = "";

  // Start is called before the first frame update
  void Start()
  {
    BoxHeaderTitle.Title.text = title;
  }

  // Update is called once per frame
  void Update()
  {

  }
}
