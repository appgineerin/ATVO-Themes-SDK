namespace ATVO.ThemesSDK.Data.Enums
{
    /// <summary>
    /// Dieses Enum beinhaltet alle Arten von Nachrichten, die an die Simulation
    /// geschickt werden können.
    /// </summary>
    /// <remarks>
    /// Es werden immer bis zu drei Integer mitgesendet. Sehen Sie in der Dokumentation
    /// der einzelnen Elemente nach, welche Parameter benötigt und benutzt werden,
    /// um eine Nachricht dieses Typs an die Simulation zu senden.
    /// </remarks>
    public enum BroadcastMessageType
    {
        /// <summary>
        /// Wechseln der Kamera.
        /// Parameter 1: Position des Autos.
        /// Parameter 2: Id der Kameragruppe.
        /// (Parameter 3: Id der einzelnen Kamera innerhalb der Gruppe.)
        /// </summary>
        CamSwitchPos = 0,

        /// <summary>
        /// Wechseln der Kamera.
        /// Parameter 1: Padded startnummer des Fahrers / Teams.
        /// Parameter 2: Id der Kameragruppe.
        /// (Parameter 3: Id der einzelnen Kamera innerhalb der Gruppe.)
        /// </summary>
        CamSwitchNum,

        /// <summary>
        /// Ändern des Status der Kamera. Siehe auch: <seealso cref="CameraState" />.
        /// Parameter 1: Neuer Status der Kamera.
        /// </summary>
        CamSetState,

        /// <summary>
        /// Ändern der Geschwindigkeit der Kamera.
        /// Parameter 1: Geschwindigkeit. Siehe auch: <seealso cref="Playspeed" />.
        /// Parameter 2: Slowmotion.
        /// </summary> 
        ReplaySetPlaySpeed,

        /// <summary>
        /// Springen im Replay.
        /// Parameter 1: ModeType. Siehe auch: <seealso cref="ReplayPositionModeType" />.
        /// Parameter 2: Framenummer (high)
        /// Parameter 3: Framenummer (low)
        /// </summary>
        ReplaySetPlayPosition,

        /// <summary>
        /// Positionen innerhalb des Replay suchen.
        /// Parameter 1: Suchmodus. Siehe auch: <seealso cref="ReplaySearchModeType" />.
        /// </summary>
        ReplaySearch,

        /// <summary>
        /// Ändern des Replay-Status.
        /// Parameter 1: Neuer Replay-Status.
        /// </summary>
        ReplaySetState, // TODO Enum einbinden.

        /// <summary>
        /// Neu lader des Texturen.
        /// Parameter 1: Mode.
        /// Parameter 2: CarIdx der neu zu ladenden Textur.
        /// </summary>
        ReloadTextures, // TODO Enum einbinden.

        /// <summary>
        /// Chat-Commands.
        /// Parameter 1: CommandMode.
        /// Parameter 2: Subcommand.
        /// </summary>
        ChatComand, // TODO Enum einbinden.

        /// <summary>
        /// Pit-Command.
        /// Parameter 1: Pit-CommandMode.
        /// Parameter 2: Parameter.
        /// </summary>
        PitCommand, // TODO Enum einbinden.

        /// <summary>
        /// Telemetry-Command.
        /// Parameter 1: Telem-CommandMode.
        /// </summary>
        TelemCommand, // TODO Enum einbinden.

        /// <summary>
        /// Dies ist ein unbenutzter Platzhalter.
        /// </summary>
        Last
    }
}
