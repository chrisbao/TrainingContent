﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientCredsAddin.Models {
  public class AppState {
    public string TenantId { get; set; }
    public string TenantDomain { get; set; }
    public string LoggedOnUser { get; set; }
    public bool AppIsAuthorized { get; set; }
    public string ExchangeOnlineAccessToken { get; set; }

    public Dictionary<string,string> MailboxList { get; set; }

    public AppState() {
      this.AppIsAuthorized = false;
      this.MailboxList = new Dictionary<string, string>();
    }
  }
}