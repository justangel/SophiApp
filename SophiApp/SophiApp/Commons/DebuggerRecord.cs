﻿namespace SophiApp.Commons
{
    internal enum DebuggerRecord
    {
        STARTUP_DIR,
        APP_VERSION,
        COMPUTER_NAME,
        OS_NAME,
        OS_EDITION,
        OS_VER,
        USER_DOMAIN,
        USER_NAME,
        LOCALIZATION,
        THEME,
        VIEW,
        UPDATE_HAS_ERROR, // Checking for an update caused an error
        UPDATE_RESPONSE_NULL, // GitHub release server not responding
        UPDATE_RESPONSE_OK, // GitHub release server responds
        UPDATE_RESPONSE_LENGTH, // In bytes
        UPDATE_VERSION_FOUND, // Has new version release
        UPDATE_VERSION_IS_PRERELEASE, // Is prerelease version
        UPDATE_VERSION_IS_DRAFT, // Is draft release version
        UPDATE_VERSION_REQUIRED, // Need update
        UPDATE_VERSION_NOT_REQUIRED, // Not need update
        INIT_TEXTED_ELEMENTS,
        TEXTED_ELEMENTS_RESET, // Reset texted elements state
        ELEMENT_STATE,
        ELEMENT_HAS_ERROR,
        ERROR_CLASS,
        ERROR_METHOD,
        ERROR_MESSAGE,
        HYPERLINK_OPEN,
        INIT_IMPORT_SETTINGS,
        INIT_EXPORT_SETTINGS,
        ADVANCED_SETTINGS_VISIBILITY,
        DEBUG_SAVE_HAS_ERROR,
        APPLYING_SETTINGS,
        CHANGED_ELEMENTS
    }
}