using Playgama;
using UnityEngine.UIElements;

public class PaymentsPanelUIHandler : PanelUIHandler {
    private readonly Label isPaymentsSupportedLabel;

    public PaymentsPanelUIHandler(UIDocument uiDocument) : base(uiDocument) {
        isPaymentsSupportedLabel = uiDocument.rootVisualElement.Q<Label>("is-payments-supported");
    }

    public override void Toggle(bool enable) {
        base.Toggle(enable);
        isPaymentsSupportedLabel.text = Bridge.payments.isSupported.ToString();
    }
}