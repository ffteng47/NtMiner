﻿using System;

namespace NTMiner.MinerClient {
    public interface ILocalIp {
        string SettingID { get; }
        string Name { get; }
        string DefaultIPGateway { get; }
        bool DHCPEnabled { get; }
        string DHCPServer { get; }
        string IPAddress { get; }
        string IPSubnet { get; }
        string DNSServer0 { get; }
        string DNSServer1 { get; }
    }
}
