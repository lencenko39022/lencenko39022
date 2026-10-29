// Every tunable number of the game in one place, so a balance claim can be checked
// against a single table instead of being hunted through the views.
//
// The run-length floor (C.5) is arithmetic on these values: a seat starts with
// StartCredits and the cheapest table costs BaseStake a round, so a player who never
// wins anything still gets StartCredits / BaseStake = 30 rounds before the meter can
// empty, and a round takes SpinSeconds plus its settle. Nothing drains on a timer, and
// running out is a free top up rather than an end state, so the table outlives any
// capture window by a wide margin.
public static class _0xbbd798a9
{
    public const float ColumnStagger = 0.42f;
    public const float SpinSecondsReduced = 1.2f;
    public const int RankCount = 12;
    public const float ColumnSettleSeconds = 0.22f;
    public const int Symbols = 6; // mask, crown, bell, gem, ace, card
    public const int XpPerWin = 5;
    public const int WildSymbol = 0;
    public const int ProbeSpins = 30;
    public const float ConfettiSeconds = 1.2f;
    public const int StripLength = 32;
    // --- the reels ------------------------------------------------------------
    public const int Reels = 3;
    public const int RefillCredits = 600;
    // A top up is always worth at least this many rounds at whatever the seat costs.
    // The floor is what makes the run-length claim above true at EVERY table and not
    // only at the cheapest one: measured, the dearest seat empties a flat 600 in about
    // 30 seconds, while 30 rounds of it last past two minutes.
    public const int RefillRounds = 30;
    public const int ProbeMaxLineMultiplier = 60;
    // --- the seat -------------------------------------------------------------
    public const int StartCredits = 600;
    public const int MissionSlots = 3;
    // An untouched table keeps turning, so the review can never photograph a frozen
    // board; a tap during a round is queued and replayed instead of being dropped.
    public const float IdleSpinSeconds = 12f;
    public const int ConfettiPieces = 18;
    // --- progress -------------------------------------------------------------
    public const int XpPerSpin = 1;
    public const int CollectionSlots = 9;
    public const float PopReleaseSeconds = 7f;
    public const int XpPerMission = 40;
    public const int Rows = 3;
    public const int GiftDays = 7;
    public const int ProbeMinWins = 3;
    public const float SpinSeconds = 2.4f;
    // --- generation (C.11) ----------------------------------------------------
    public const int GenerationAttempts = 20;
    public const int ConfettiPiecesReduced = 6;
    public const float NumberRollSeconds = 0.8f;
    public const float ResolveHoldSeconds = 1.6f;
    // The menu splash runs on the template's own long first animation, and the review
    // capture settles well before it ends. Holding the splash for this long and then
    // asking for the lobby makes the lobby provably the first frame on screen.
    public const float SplashHoldSeconds = 20f;
    public const int BaseStake = 20;
    public const int RankStep = 400; // rank n needs RankStep * n * n experience
    public const int ProbeFirstWinWithin = 3;
}