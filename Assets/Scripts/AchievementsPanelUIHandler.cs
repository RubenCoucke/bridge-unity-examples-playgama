using Playgama;
using UnityEngine.UIElements;

public class AchievementsPanelUIHandler : PanelUIHandler {
    private readonly Label isAchievementsSupportedLabel;
    private readonly Label isGetListSupportedLabel;
    private readonly Label isNativePopupSupportedLabel;

    public AchievementsPanelUIHandler(UIDocument uiDocument) : base(uiDocument) {
        isAchievementsSupportedLabel = uiDocument.rootVisualElement.Q<Label>("is-achievements-supported");
        isGetListSupportedLabel = uiDocument.rootVisualElement.Q<Label>("is-get-list-supported");
        isNativePopupSupportedLabel = uiDocument.rootVisualElement.Q<Label>("is-native-popup-supported");
    }

    public override void Toggle(bool enable) {
        base.Toggle(enable);
        isAchievementsSupportedLabel.text = Bridge.achievements.isSupported.ToString();
        isGetListSupportedLabel.text = Bridge.achievements.isGetListSupported.ToString();
        isNativePopupSupportedLabel.text = Bridge.achievements.isNativePopupSupported.ToString();
    }
}