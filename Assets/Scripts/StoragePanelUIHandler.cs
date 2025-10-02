using Playgama;
using Playgama.Modules.Storage;
using UnityEngine.UIElements;

public class StoragePanelUIHandler : PanelUIHandler { 
    private readonly Label storageTypeLabel;
    private readonly Label isLocalStorageSupportedLabel;
    private readonly Label isLocalStorageAvailableLabel;
    private readonly Label isPlatformInternalSupportedLabel;
    private readonly Label isPlatformInternalAvailableLabel;

    public StoragePanelUIHandler(UIDocument uiDocument) : base(uiDocument) {
        storageTypeLabel = uiDocument.rootVisualElement.Q<Label>("storage-type");
        isLocalStorageAvailableLabel = uiDocument.rootVisualElement.Q<Label>("is-local-storage-available");
        isPlatformInternalAvailableLabel = uiDocument.rootVisualElement.Q<Label>("is-platform-internal-available");
        isLocalStorageSupportedLabel = uiDocument.rootVisualElement.Q<Label>("is-local-storage-supported");
        isPlatformInternalSupportedLabel = uiDocument.rootVisualElement.Q<Label>("is-platform-internal-supported");
    }

    public override void Toggle(bool enable) {
        base.Toggle(enable);
        storageTypeLabel.text = Bridge.storage.defaultType.ToString();
        isLocalStorageAvailableLabel.text = Bridge.storage.IsAvailable(StorageType.LocalStorage).ToString();
        isPlatformInternalAvailableLabel.text = Bridge.storage.IsAvailable(StorageType.PlatformInternal).ToString();
        isLocalStorageSupportedLabel.text = Bridge.storage.IsSupported(StorageType.LocalStorage).ToString();
        isPlatformInternalSupportedLabel.text = Bridge.storage.IsSupported(StorageType.PlatformInternal).ToString();
    }
}