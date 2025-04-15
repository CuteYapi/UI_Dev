using ClassDefine;
using UnityEngine;

public class InventoryConsumeController : MonoBehaviour, IUI
{
    public ButtonController[] ButtonControllerArray = new ButtonController[2];
    public TextView[] TextViewArray = new TextView[3];

    public ConsumeItemButtonController RefConsumeItemButton;
    public Transform InventoryListTransform;

    public void Initialize()
    {
        foreach (var button in ButtonControllerArray)
        {
            button.Initialize();
        }

        ButtonControllerArray[0].SetButtonAction(() =>
        {
            Log.Message("획득 장소 UI 출력", LogCategory.InventoryConsume);
        });
        ButtonControllerArray[1].SetButtonAction(() =>
        {
            Log.Message("열기 버튼 출력", LogCategory.InventoryConsume);
        });

        SetInventoryListButton();

        Open();
    }

    public void Open()
    {
        gameObject.SetActive(true);

        ConsumeInfo targetItem = Manager.Data.ConsumeItemList[0];
        SetItemConsumeText(targetItem);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    public void SetItemConsumeText(ConsumeInfo targetItem)
    {
        TextViewArray[0].SetText(targetItem.Name);
        TextViewArray[1].SetText(targetItem.Description);

        string countText = $"보유 수량\nx{targetItem.Count}";
        TextViewArray[2].SetText(countText);
    }

    private void SetInventoryListButton()
    {
        foreach(ConsumeInfo consumeInfo in Manager.Data.ConsumeItemList)
        {
            ConsumeInfo localConsumeInfo = consumeInfo;

            ConsumeItemButtonController consumeItemButton = Instantiate(RefConsumeItemButton, InventoryListTransform);
            consumeItemButton.Initialize();
            consumeItemButton.gameObject.SetActive(true);
            consumeItemButton.CountText.text = $"x{localConsumeInfo.Count}";
            consumeItemButton.SetButtonAction(() =>
            {
                SetSelectConsumeItem(localConsumeInfo);
            });
        }
    }

    private void SetSelectConsumeItem(ConsumeInfo consumeInfo)
    {
        SetItemConsumeText(consumeInfo);
    }
}
