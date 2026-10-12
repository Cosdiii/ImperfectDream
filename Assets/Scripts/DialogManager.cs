using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.IO;

public class DialogManager : MonoBehaviour
{
    //對話文本文件 csv格式
    public TextAsset dialogDataFile;

    //左側角色圖像
    public SpriteRenderer spriteLeft;
    //右側角色圖像
    public SpriteRenderer spriteRight;

    //角色圖片列表
    public List<Sprite> sprites = new List<Sprite>();
    //角色名字對應圖片字典
    Dictionary<string, Sprite> imageDic = new Dictionary<string, Sprite>();


    //cg名字對應圖片字典
    Dictionary<string, Sprite> cgImages = new Dictionary<string, Sprite>();

    //角色圖片列表
    public List<Sprite> cgs = new List<Sprite>(); // CG 图片列表，与名称对应
    public SpriteRenderer cgImage; // 引用 UI 图片元素


    //角色名字文件
    public TMP_Text nameText;
    //對話內容文本
    public TMP_Text dialogText;

    //當前的對話索引值
    public int dialogIndex;

    //對話文本,按行分割
    public string[] dialogRows;

    public Button nextButton;
    public GameObject optionButton;
    public Transform ButtonGroup;

    public GameObject Dialog;


    private void Awake()
    {
        imageDic["賀長樂"] = sprites[0];
        imageDic["賀笙"] = sprites[1];
        cgImages["X"] = cgs[0];
        cgImages["遙控器"] = cgs[1];
    }

    // Start is called before the first frame update
    public void Start()
    {
        ReadText(dialogDataFile);
        ShowDialogRow();
        //UpdateText("賀笙", "你好");
        //UpdateImage("賀長樂",false);
        //UpdateCGImage("遙控器");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void UpdateText(string _name, string _text)
    {
        nameText.text = _name;
        dialogText.text = _text;

    }

    public void UpdateImage(string _name, string _position)
    {

        if (_position == "左")
        {
            spriteLeft.sprite = imageDic[_name];
        }
        else if (_position == "右")
        {
            spriteRight.sprite = imageDic[_name];
        }
    }


    public void UpdateCGImage(string _cgname)
    {
        cgImage.sprite = cgImages[_cgname];
    }


    public void ReadText(TextAsset _textAsset)
    {
        dialogRows = _textAsset.text.Split('\n');
       // foreach(var row in rows) 
       // {
       //     string[] cell = row.Split(',');
       // }
        Debug.Log("讀取成功");

    }

    public void ShowDialogRow()
    {

        for (int i = 0; i < dialogRows.Length; i++) 
        {
            string[] cells = dialogRows[i].Split(',');
            if (cells[0] == "D" && int.Parse(cells[1]) == dialogIndex)
            {
                UpdateText(cells[2], cells[4]);
                UpdateImage(cells[2], cells[3]);
                UpdateCGImage(cells[6]);

                dialogIndex = int.Parse(cells[5]);
                nextButton.gameObject.SetActive(true);
                break;
            }
            else if (cells[0] == "O" && int.Parse(cells[1]) == dialogIndex)
            {
                nextButton.gameObject.SetActive(false);
                ButtonGroup.gameObject.SetActive(true);
                GenerateOption(i);
            }
            else if (cells[0] == "END" && int.Parse(cells[1]) == dialogIndex)
            {
                Debug.Log("劇情結束");
                Dialog.SetActive(false);
            }
        }
    }


    public void OnClickNext() 
    {
        ShowDialogRow();
    }


    public void GenerateOption(int _index)
    {
        string[] cells = dialogRows[_index].Split(',');
        if (cells[0] == "O")
        {
                GameObject button = Instantiate(optionButton, ButtonGroup);
                //綁定按鈕事件
                button.GetComponentInChildren<TMP_Text>().text = cells[4];
                button.GetComponent<Button>().onClick.AddListener(delegate { OnOptionClick(int.Parse(cells[5])); });
             GenerateOption(_index + 1);
        }
       
    }

    public void OnOptionClick(int _id) 
    {
        dialogIndex = _id;
        ShowDialogRow();
        for (int i = 0; i < ButtonGroup.childCount; i++)
        {
            Destroy(ButtonGroup.GetChild(i).gameObject);
        }
    }

}

