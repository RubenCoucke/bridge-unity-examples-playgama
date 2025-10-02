using Playgama;
using UnityEngine.UIElements;

public class RemoteConfigPanelUIHandler : PanelUIHandler {
    private readonly Label isRemoteConfigSupportedLabel;

    public RemoteConfigPanelUIHandler(UIDocument uiDocument) : base(uiDocument) {
        isRemoteConfigSupportedLabel = uiDocument.rootVisualElement.Q<Label>("is-remote-config-supported");
    }

    public override void Toggle(bool enable) {
        base.Toggle(enable);
        isRemoteConfigSupportedLabel.text = Bridge.remoteConfig.isSupported.ToString();
    }
}