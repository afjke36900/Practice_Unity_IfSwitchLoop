using UnityEngine;
using UnityEngine.UI;

public class PracticeScript : MonoBehaviour
{
    // 封裝欄位
    // 1.私人欄位
    private float hp;
    // 2.屬性 : 讀寫或唯讀
    public float Hp { get => sliderHp.value; set => hp = value; }

    [Header("滑桿%數")]
    public Text curentHP;
    [Header("滑桿的值")]
    public Slider sliderHp;
    [Header("結果")]
    public Text resultSlider;    

    [Header("輸入欄位")]
    public InputField inputField;  
    [Header("輸入欄位結果")]
    public Text resultInputField;

    [Header("方塊")]
    public GameObject cube;

    private void Start()
    {
        #region 練習 3
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < (i + 1); j++)
            {
                Vector3 pos = new Vector3(i*2, j * 2, 0);
                Instantiate(cube, pos, Quaternion.identity);
            }
        }
        #endregion
    }

    private void Update()
    {
        curentHP.text = sliderHp.value.ToString("f0");

        #region 練習 1
        if (Hp <= 30)
        {
            resultSlider.text = "<color=#ff0000ff>" + "<size=150><b>危險</b></size>" + "</color>" ;
        }        
        
        else if (Hp <= 70)
        {
            resultSlider.text = "<color=#ffa500ff>" + "警告" + "</color>";
        }        
        
        else
        {
            resultSlider.text = "<color=#00ff00ff>" + "安全" + "</color>";
        }
        #endregion

        #region 練習 2
        // 輸入欄位結果.文字 = 如果輸入 == 紅水 ? 恢復血量 : 如果輸入 == 藍水 ? 恢復魔力 : "" ;
        resultInputField.text = inputField.text == "紅水" ? "恢復血量" : inputField.text == "藍水" ? "恢復魔力" : "錯誤的資料";
        #endregion
    }
}