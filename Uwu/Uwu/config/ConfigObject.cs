﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Uwu.config
{
    public class ConfigObject
    {
        [JsonProperty("botSecretToken")]
        public string BotSecretToken { get; set; }
        public string GameActive { get; set; }
    }
}
