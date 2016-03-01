using System;

namespace ATVO.ThemesSDK.Data.Enums
{
    /// <summary>
    /// Dieses Bitfeld beschreibt die verschiedenen Zustände, die
    /// die Kamera in iRacing annehmen kann.
    /// </summary>
    [Flags]
    public enum CameraState
    {
        /// <summary>
        /// Leerer Zustand.
        /// </summary>
        None = 0x0000,

        /// <summary>
        /// Beschreibt, ob der Session-Screen aktiv ist oder nicht.
        /// </summary>
        IsSessionScreen = 0x0001,

        /// <summary>
        /// Beschreibt, ob die aktuelle Kamera szenisch ist oder nicht.
        /// </summary>
        IsScenicActive = 0x0002,

        /// <summary>
        /// Beschreibt, ob das Kameratool aktiv ist oder nicht.
        /// </summary>
        CamToolActive = 0x0004,

        /// <summary>
        /// Beschreibt, ob das UI ausgeblendet ist oder nicht.
        /// </summary>
        UIHidden = 0x0008,
        UseAutoShotSelection = 0x0010,
        UseTemporaryEdits = 0x0020,
        UseKeyAcceleration = 0x0040,
        UseKey10xAcceleration = 0x0080,

        /// <summary>
        /// Beschreibt, ob der Mouse-Modus aktiv ist oder nicht.
        /// </summary>
        UseMouseAimMode = 0x0100
    }
}
