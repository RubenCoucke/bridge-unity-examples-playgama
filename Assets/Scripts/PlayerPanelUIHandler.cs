using Playgama;
using UnityEngine.UIElements;

public class PlayerPanelUIHandler : PanelUIHandler {
    private readonly Label isAuthSupportedLabel;
    private readonly Label isAuthorizedLabel;
    private readonly Label playerIDLabel;
    private readonly Label playerNameLabel;

    public PlayerPanelUIHandler(UIDocument uiDocument) : base(uiDocument) {
        isAuthorizedLabel = uiDocument.rootVisualElement.Q<Label>("is-authorized");
        isAuthSupportedLabel = uiDocument.rootVisualElement.Q<Label>("is-auth-supported");
        playerIDLabel = uiDocument.rootVisualElement.Q<Label>("player-id");
        playerNameLabel = uiDocument.rootVisualElement.Q<Label>("player-name");
    }

    public override void Toggle(bool enable) {
        base.Toggle(enable);
        isAuthorizedLabel.text = Bridge.player.isAuthorized.ToString();
        isAuthSupportedLabel.text = Bridge.player.isAuthorizationSupported.ToString();
        playerIDLabel.text = Bridge.player.id;
        playerNameLabel.text = Bridge.player.name;
    }
}