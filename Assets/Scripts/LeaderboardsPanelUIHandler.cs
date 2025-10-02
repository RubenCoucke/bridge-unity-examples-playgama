using Playgama;
using UnityEngine.UIElements;

public class LeaderboardsPanelUIHandler : PanelUIHandler {
    private readonly Label leaderboardTypeLabel;

    public LeaderboardsPanelUIHandler(UIDocument uiDocument) : base(uiDocument) {
        leaderboardTypeLabel = uiDocument.rootVisualElement.Q<Label>("leaderboard-type");
    }

    public override void Toggle(bool enable) {
        base.Toggle(enable);
        leaderboardTypeLabel.text = Bridge.leaderboards.type.ToString();
    }
}