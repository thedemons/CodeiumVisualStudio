﻿using System.ComponentModel;
using System.Runtime.InteropServices;

namespace CodeiumVS;

[ComVisible(true)]
public class SettingsPage : DialogPage
{
    private bool enterpriseMode;
    private string portalUrl = "";
    private string apiUrl = "";
    private bool enableCommentCompletion = true;
    private bool enableLanguageServerProxy = false;

    [Category("Codeium")]
    [DisplayName("Enterprise Mode")]
    [Description(
        "Set this to True if using Visual Studio with Codeium Enterprise. Requires restart.")]
    public bool EnterpriseMode
    {
        get {
            return enterpriseMode;
        }
        set {
            enterpriseMode = value;
        }
    }

    [Category("Codeium")]
    [DisplayName("Portal Url")]
    [Description("URL of the Codeium Enterprise Portal. Requires restart.")]
    public string PortalUrl
    {
        get {
            return portalUrl;
        }
        set {
            portalUrl = value;
        }
    }

    [Category("Codeium")]
    [DisplayName("API Url")]
    [Description("API Url for Codeium Enterprise. Requires restart.")]
    public string ApiUrl
    {
        get {
            return apiUrl;
        }
        set {
            apiUrl = value;
        }
    }

    [Category("Codeium")]
    [DisplayName("Enable comment completion")]
    [Description("Whether or not Codeium will provide completions for comments.")]
    public bool EnableCommentCompletion
    {
        get {
            return enableCommentCompletion;
        }
        set {
            enableCommentCompletion = value;
        }
    }

    [Category("Codeium")]
    [DisplayName("Enable language server proxy")]
    [Description(
        "If you're experiencing network issues with the language server, we recommend enabling this option and using a VPN to resolve the issue. Requires restart.")]
    public bool EnableLanguageServerProxy
    {
        get {
            return enableLanguageServerProxy;
        }
        set {
            enableLanguageServerProxy = value;
        }
    }
}
