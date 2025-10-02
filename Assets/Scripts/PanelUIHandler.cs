using System;
using Playgama;
using UnityEngine.UIElements;

public abstract class PanelUIHandler {
    private readonly UIDocument uiDocument;

    public event Action BackPressed = delegate { };
    
    protected PanelUIHandler(UIDocument uiDocument) {
        this.uiDocument = uiDocument;
        uiDocument.enabled = true;
        uiDocument.rootVisualElement.style.display = DisplayStyle.None;
        InitBackButton();
    }

    private void InitBackButton() {
        var button = uiDocument.rootVisualElement.Q<VisualElement>(className:"header-btn__back-button");
        button.focusable = true;
        button.RegisterCallback<ClickEvent>(_ => {
            Toggle(false);
            BackPressed();
        });   
    }

    public virtual void Toggle(bool enable) {
        uiDocument.rootVisualElement.style.display = enable ? DisplayStyle.Flex : DisplayStyle.None;
    }      
}